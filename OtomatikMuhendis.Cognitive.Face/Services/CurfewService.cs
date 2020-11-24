using OtomatikMuhendis.Cognitive.Face.Core;

namespace OtomatikMuhendis.Cognitive.Face.Services
{
    public class CurfewService : ICurfewService
    {
        public bool IsFreeToGoOut(CurfewRequest curfewRequest)
        {
            if (curfewRequest.IsWeekend() &&
                curfewRequest.IsOutsideOfHours(10, 20))
                return false;

            if (curfewRequest.IsUnder20())
                return curfewRequest.IsBetweenHours(13, 16);

            if (curfewRequest.IsOver64())
                return curfewRequest.IsBetweenHours(10, 13);

            return true;
        }
    }
}
