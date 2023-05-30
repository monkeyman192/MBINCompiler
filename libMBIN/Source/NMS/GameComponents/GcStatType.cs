using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcStatType : NMSTemplate // not the same as GcStatsTypes
    {
        public int StatType;
        public string[] StatTypeValues()
        {
            return new[] { "Int", "Float", "AvgRate" };
        }
    }
}
