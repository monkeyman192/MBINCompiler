using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE1C5A2109D4E48CC, NameHash = 0xB9BE65CA55BBE004)]
    public class GcRewardHazard : NMSTemplate
    {
        public int AmountMin;
        public int AmountMax;
        public bool Silent;
    }
}