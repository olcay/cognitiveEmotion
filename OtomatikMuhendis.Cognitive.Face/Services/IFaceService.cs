using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;

namespace OtomatikMuhendis.Cognitive.Face.Services
{
    public interface IFaceService
    {
        Task<FaceAttributes> DetectFaceAttributesAsync(string imageData, FaceAttributeType faceAttributeType);
    }
}