using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcGalaxyStarTypes : NMSTemplate
    {
        public int GalaxyStarType;
        public string[] GalaxyStarTypeValues()
        {
            return new[] { "Yellow", "Green", "Blue", "Red" };
        }
    }
}
