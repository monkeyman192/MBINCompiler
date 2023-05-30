using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcPrimaryAxis : NMSTemplate
    {
        public int PrimaryAxis;
        public string[] PrimaryAxisValues()
        {
            return new[] { "Z", "ZNeg" };
        }
    }
}
