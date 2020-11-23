using System;

namespace OtomatikMuhendis.Cognitive.Face.Services
{
    public interface ICurfewService
    {
        bool IsFreeToGoOut(double? age, DateTimeOffset time);
    }
}