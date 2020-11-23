using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;
using OtomatikMuhendis.Cognitive.Face.Core;
using OtomatikMuhendis.Cognitive.Face.Models;
using OtomatikMuhendis.Cognitive.Face.Services;

namespace OtomatikMuhendis.Cognitive.Face.Controllers
{
    public class FaceController : ControllerBase
    {
        private readonly IFaceService _faceService;
        private readonly ICurfewService _curfewService;

        public FaceController(ICurfewService curfewService, IFaceService faceService)
        {
            _curfewService = curfewService;
            _faceService = faceService;
        }

        [HttpPost]
        public async Task<IActionResult> DetectAge([FromBody] FaceViewModel model)
        {
            var faceAttributes = await _faceService.DetectFaceAttributesAsync(model.ImageData, 
                FaceAttributeType.Age);

            var curfewResult = new CurfewResult { Age = faceAttributes?.Age };
            curfewResult.IsFree = _curfewService.IsFreeToGoOut(curfewResult.Age, DateTimeOffset.Now);

            return Ok(curfewResult);
        }

        [HttpPost]
        public async Task<IActionResult> DetectEmotion([FromBody] FaceViewModel model)
        {
            var faceAttributes = await _faceService.DetectFaceAttributesAsync(model.ImageData, 
                FaceAttributeType.Emotion);

            return Ok(faceAttributes?.Emotion);
        }
    }
}
