using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0x19071614D76515B5, NameHash = 0xBAC710ADD80D9C59)]
    public class GcStatsBonus : NMSTemplate
    {
        public GcStatsTypes StatType;
        public float Bonus;
        public int Level;
    }
}
