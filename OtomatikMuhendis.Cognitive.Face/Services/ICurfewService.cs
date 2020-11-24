using OtomatikMuhendis.Cognitive.Face.Core;

namespace OtomatikMuhendis.Cognitive.Face.Services
{
    public interface ICurfewService
    {
        bool IsFreeToGoOut(CurfewRequest curfewRequest);
    }
}