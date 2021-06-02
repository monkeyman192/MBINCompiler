using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, Alignment = 0x8, GUID = 0xE42E6781D16F3D1F, NameHash = 0xCE090483FC7B2C67)]
    public class GcRewardCommunityContribution : NMSTemplate
    {
        /* 0x00 */ public GcAtlasSendSubmitContribution Contribution;

        public enum SubmitTypeEnum { Value, Stat, StatsDiff }
        /* 0x08 */ public SubmitTypeEnum SubmitType;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0C */ public byte[] PaddingC;

        /* 0x10 */ public NMSString0x10 Stat;
        /* 0x20 */ public NMSString0x10 OtherStat;
    }
}
