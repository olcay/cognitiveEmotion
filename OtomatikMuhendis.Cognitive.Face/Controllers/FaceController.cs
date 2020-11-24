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

            var nowInTurkey = DateTimeOffset.Now.AddHours(3);

            var curfewResult = new CurfewResult { Age = faceAttributes?.Age };
            var curfewRequest = new CurfewRequest(curfewResult.Age ?? 0, nowInTurkey.DayOfWeek, nowInTurkey.Hour);

            curfewResult.IsFree = _curfewService.IsFreeToGoOut(curfewRequest);

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
