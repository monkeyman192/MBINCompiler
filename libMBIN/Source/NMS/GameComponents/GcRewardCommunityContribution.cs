using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE42E6781D16F3D1F, NameHash = 0xCE090483FC7B2C67)]
    public class GcRewardCommunityContribution : NMSTemplate
    {
        /* 0x00 */ public GcAtlasSendSubmitContribution Contribution;

        public enum SubmitTypeEnum { Value, Stat, StatsDiff }
        /* 0x08 */ public SubmitTypeEnum SubmitType;

        /* 0x10 */ public NMSString0x10 Stat;
        /* 0x20 */ public NMSString0x10 OtherStat;
    }
}
