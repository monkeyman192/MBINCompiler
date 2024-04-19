using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2A90662F35B374DF, NameHash = 0x33CAC73016241300)]
    public class GcJourneyMedal : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A MedalProgressText;
        /* 0x020 */ public NMSString0x20A MedalTitle;
        /* 0x040 */ public NMSString0x20A PinnedDescription;
        /* 0x060 */ public NMSString0x10 LevelledStatID;
        /* 0x070 */ public NMSString0x10 PinnedMission;
        /* 0x080 */ public TkTextureResource IconBronze;
        /* 0x104 */ public TkTextureResource IconGold;
        /* 0x188 */ public TkTextureResource IconNone;
        /* 0x20C */ public TkTextureResource IconSilver;
        /* 0x290 */ public GcStatType StatType;
        /* 0x294 */ public bool OverallJourneyDummy;
    }
}
