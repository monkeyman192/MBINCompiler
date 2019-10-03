using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x8, GUID = 0x901BBD280C22EEE4, NameHash = 0x691B32769ECE3BC6)]
    public class GcRewardSpecificProduct : NMSTemplate
    {
        public GcDefaultMissionProductEnum Default;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        [NMS(Size = 0x10)]
        public string Id;
        public int AmountMin;
        public int AmountMax;
    }
}
