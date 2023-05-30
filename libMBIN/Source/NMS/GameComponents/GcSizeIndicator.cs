using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcSizeIndicator : NMSTemplate
    {
        public int SizeIndicator;
        public string[] SizeIndicatorValues()
        {
            return new[] { "Small", "Medium", "Large" };
        }
    }
}
