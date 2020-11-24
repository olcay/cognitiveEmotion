using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Azure.CognitiveServices.Vision.Face;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;

namespace OtomatikMuhendis.Cognitive.Face.Services
{
    public class FaceService : IFaceService
    {
        private static IHostingEnvironment _environment;

        private readonly IFaceClient _faceClient;

        public FaceService(IFaceClient faceClient, IHostingEnvironment environment)
        {
            _faceClient = faceClient;
            _environment = environment;
        }

        public async Task<FaceAttributes> DetectFaceAttributesAsync(string imageData, FaceAttributeType faceAttributeType)
        {
            var filePath = _environment.WebRootPath + Path.DirectorySeparatorChar +
                           "uploads" + Path.DirectorySeparatorChar + Convert.ToString(Guid.NewGuid()) + ".jpg";

            FaceAttributeType[] faceAttributes = { faceAttributeType };

            try
            {
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    using (var binaryWriter = new BinaryWriter(fileStream))

                    {
                        var byteArray = Convert.FromBase64String(imageData);
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
                        return faceList[0].FaceAttributes;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Face not detected." + e.Message);
            }
            finally
            {
                try
                {
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }
                }
                catch (IOException ioExp)
                {
                    Console.WriteLine(ioExp.Message);
                }
            }

            return null;
        }
    }
}
