using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7D5987E0615F9C9C, NameHash = 0x691B32769ECE3BC6)]
    public class GcRewardSpecificProduct : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x00 */ public NMSString0x20A SeasonRewardListFormat;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 ID;
        [NMS(Index = 9)]
        /* 0x30 */ public NMSString0x10 RequiresTech;
        [NMS(Index = 3)]
        /* 0x40 */ public int AmountMax;
        [NMS(Index = 2)]
        /* 0x44 */ public int AmountMin;
        [NMS(Index = 0)]
        /* 0x48 */ public GcDefaultMissionProductEnum Default;
        [NMS(Index = 5)]
        /* 0x4C */ public bool ForceSpecialMessage;
        [NMS(Index = 4)]
        /* 0x4D */ public bool HideAmountInMessage;
        [NMS(Index = 6)]
        /* 0x4E */ public bool HideInSeasonRewards;
        [NMS(Index = 7)]
        /* 0x4F */ public bool Silent;
    }
}
