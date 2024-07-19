using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x49C0FCF487514038, NameHash = 0xF06025B9)]
    public class GcJourneyMedal : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A MedalProgressText;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A MedalTitle;
        [NMS(Index = 3)]
        /* 0x40 */ public NMSString0x20A PinnedDescription;
        [NMS(Index = 8)]
        /* 0x60 */ public TkTextureResource IconBronze;
        [NMS(Index = 10)]
        /* 0x78 */ public TkTextureResource IconGold;
        [NMS(Index = 7)]
        /* 0x90 */ public TkTextureResource IconNone;
        [NMS(Index = 9)]
        /* 0xA8 */ public TkTextureResource IconSilver;
        [NMS(Index = 0)]
        /* 0xC0 */ public NMSString0x10 LevelledStatID;
        [NMS(Index = 4)]
        /* 0xD0 */ public NMSString0x10 PinnedMission;
        [NMS(Index = 5)]
        /* 0xE0 */ public GcStatType StatType;
        [NMS(Index = 6)]
        /* 0xE4 */ public bool OverallJourneyDummy;
    }
}
