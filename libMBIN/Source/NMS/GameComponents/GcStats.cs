using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcStats : NMSTemplate
    {
        [NMS(Size = 4)]
        public GcStatsGroup[] Stats;
    }
}
