using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD41F393835F21A5C, NameHash = 0x5EB151C3)]
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
        [NMS(Index = 4)]
        /* 0x2C */ public bool AutosaveOnHandIn;
    }
}
