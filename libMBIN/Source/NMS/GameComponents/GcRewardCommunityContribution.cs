using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x38, GUID = 0x89B5232517B88E96, NameHash = 0xCE090483FC7B2C67)]
    public class GcRewardCommunityContribution : NMSTemplate
    {
        /* 0x00 */ public GcAtlasSendSubmitContribution Contribution;      // list of??

        public enum SubmitTypeEnum { Value, Stat, StatsDiff }
        /* 0x10 */ public SubmitTypeEnum SubmitType;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14 */ public byte[] Padding14;

        [NMS(Size = 0x10)]
        /* 0x18 */ public string Stat;
        [NMS(Size = 0x10)]
        /* 0x28 */ public string OtherStat;
    }
}
