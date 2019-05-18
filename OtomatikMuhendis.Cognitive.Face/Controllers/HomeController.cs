using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.CognitiveServices.Vision.Face;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;
using OtomatikMuhendis.Cognitive.Face.Models;

namespace OtomatikMuhendis.Cognitive.Face.Controllers
{
    public class HomeController : Controller
    {
        private static IHostingEnvironment _environment;

        private readonly IFaceClient _faceClient;

        public HomeController(IFaceClient faceClient, IHostingEnvironment environment)
        {
            _faceClient = faceClient;
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Face([FromBody] FaceViewModel model)
        {
            var filePath = _environment.WebRootPath + Path.DirectorySeparatorChar +
                           "uploads" + Path.DirectorySeparatorChar + Convert.ToString(Guid.NewGuid()) + ".jpg";

            FaceAttributeType[] faceAttributes = { FaceAttributeType.Emotion };

            Emotion emotion = null;

            try
            {
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    using (var binaryWriter = new BinaryWriter(fileStream))

                    {
                        var byteArray = Convert.FromBase64String(model.ImageData);
                        binaryWriter.Write(byteArray);
                        binaryWriter.Close();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File not created." + e.Message);
            }

            try
            {
                using (Stream imageStream = new FileStream(filePath, FileMode.Open))
                {
                    var faceList = await _faceClient.Face.DetectWithStreamAsync(
                        imageStream, true, false, faceAttributes);

                    if (faceList.Any())
                    {
                        emotion = faceList[0].FaceAttributes.Emotion;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Face not detected." + e.Message);
            }

            try
            {
                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Delete(filePath);
                    Console.WriteLine("File deleted.");
                }
                else
                {
                    Console.WriteLine("File not found.");
                }
            }
            catch (IOException ioExp)
            {
                Console.WriteLine(ioExp.Message);
            }

            return Ok(emotion);
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
