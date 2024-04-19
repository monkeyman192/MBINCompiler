using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDE59F45CE9E07E11, NameHash = 0x864FCB26DF972FCF)]
    public class GcPlayerTitle : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A AlreadyUnlockedDescription;
        /* 0x20 */ public NMSString0x20A Title;
        /* 0x40 */ public NMSString0x20A UnlockDescription;
        /* 0x60 */ public NMSString0x10 ID;
        /* 0x70 */ public NMSString0x10 RevealedBy;
        /* 0x80 */ public NMSString0x10 UnlockedByMission;
        /* 0x90 */ public NMSString0x10 UnlockedByProductRecipe;
        /* 0xA0 */ public NMSString0x10 UnlockedByStat;
        /* 0xB0 */ public NMSString0x10 UnlockedByTrophy;
        /* 0xC0 */ public GcInteractionType UnlockedByInteraction;
        /* 0xC4 */ public int UnlockedByInteractionIndex;
        /* 0xC8 */ public GcAlienRace UnlockedByInteractionRace;
        /* 0xCC */ public int UnlockedByLeveledStatRank;
        /* 0xD0 */ public float UnlockedByStatValue;
        /* 0xD4 */ public bool UnlockedByInteractionOnlyTestMainRaces;
    }
}
