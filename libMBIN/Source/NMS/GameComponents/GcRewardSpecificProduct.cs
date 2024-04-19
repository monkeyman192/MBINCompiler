using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7D5987E0615F9C9C, NameHash = 0x691B32769ECE3BC6)]
    public class GcRewardSpecificProduct : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A SeasonRewardListFormat;
        /* 0x20 */ public NMSString0x10 ID;
        /* 0x30 */ public NMSString0x10 RequiresTech;
        /* 0x40 */ public int AmountMax;
        /* 0x44 */ public int AmountMin;
        /* 0x48 */ public GcDefaultMissionProductEnum Default;
        /* 0x4C */ public bool ForceSpecialMessage;
        /* 0x4D */ public bool HideAmountInMessage;
        /* 0x4E */ public bool HideInSeasonRewards;
        /* 0x4F */ public bool Silent;
    }
}
