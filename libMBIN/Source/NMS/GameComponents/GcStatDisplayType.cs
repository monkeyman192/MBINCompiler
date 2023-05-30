using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcStatDisplayType : NMSTemplate
    {
        public int StatDisplayType;
        public string[] StatDisplayTypeValues()
        {
            return new[] { "None", "Sols", "Distance" };
        }
    }
}
