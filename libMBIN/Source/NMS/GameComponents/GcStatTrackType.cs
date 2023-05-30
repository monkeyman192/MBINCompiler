using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcStatTrackType : NMSTemplate
    {
        public int StatTrackType;
        public string[] StatTrackTypeValues()
        {
            return new[] { "Set", "Add", "Max", "Min" };
        }
    }
}
