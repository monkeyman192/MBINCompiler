using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2A90662F35B374DF, NameHash = 0x33CAC73016241300)]
    public class GcJourneyMedal : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public NMSString0x20A MedalProgressText;
        [NMS(Index = 1)]
        /* 0x020 */ public NMSString0x20A MedalTitle;
        [NMS(Index = 3)]
        /* 0x040 */ public NMSString0x20A PinnedDescription;
        [NMS(Index = 0)]
        /* 0x060 */ public NMSString0x10 LevelledStatID;
        [NMS(Index = 4)]
        /* 0x070 */ public NMSString0x10 PinnedMission;
        [NMS(Index = 8)]
        /* 0x080 */ public TkTextureResource IconBronze;
        [NMS(Index = 10)]
        /* 0x104 */ public TkTextureResource IconGold;
        [NMS(Index = 7)]
        /* 0x188 */ public TkTextureResource IconNone;
        [NMS(Index = 9)]
        /* 0x20C */ public TkTextureResource IconSilver;
        [NMS(Index = 5)]
        /* 0x290 */ public GcStatType StatType;
        [NMS(Index = 6)]
        /* 0x294 */ public bool OverallJourneyDummy;
    }
}
