using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcWarpAction : NMSTemplate
    {
        public int WarpType;
        public string[] WarpTypeValues()
        {
            return new[] { "BlackHole" }; // one value? :D:D
        }
    }
}
