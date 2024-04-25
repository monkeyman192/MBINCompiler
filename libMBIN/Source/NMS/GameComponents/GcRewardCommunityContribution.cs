using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA8EC14D17EF48A02, NameHash = 0xCE090483FC7B2C67)]
    public class GcRewardCommunityContribution : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x10 OtherStat;
        [NMS(Index = 2)]
        /* 0x10 */ public NMSString0x10 Stat;
        [NMS(Index = 0)]
        /* 0x20 */ public GcAtlasSendSubmitContribution Contribution;
        // size: 0x3
        public enum SubmitTypeEnum : uint {
            Value,
            Stat,
            StatsDiff,
        }
        [NMS(Index = 1)]
        /* 0x28 */ public SubmitTypeEnum SubmitType;
    }
}
