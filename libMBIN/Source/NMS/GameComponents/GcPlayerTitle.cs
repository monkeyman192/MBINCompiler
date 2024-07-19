using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x45D19156D8B6DDC5, NameHash = 0xE11E0D40)]
    public class GcPlayerTitle : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x20A AlreadyUnlockedDescription;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A Title;
        [NMS(Index = 2)]
        /* 0x40 */ public NMSString0x20A UnlockDescription;
        [NMS(Index = 0)]
        /* 0x60 */ public NMSString0x10 ID;
        [NMS(Index = 4)]
        /* 0x70 */ public NMSString0x10 RevealedBy;
        [NMS(Index = 6)]
        /* 0x80 */ public NMSString0x10 UnlockedByMission;
        [NMS(Index = 5)]
        /* 0x90 */ public NMSString0x10 UnlockedByProductRecipe;
        [NMS(Index = 8)]
        /* 0xA0 */ public NMSString0x10 UnlockedByStat;
        [NMS(Index = 7)]
        /* 0xB0 */ public NMSString0x10 UnlockedByTrophy;
        [NMS(Index = 11)]
        /* 0xC0 */ public GcInteractionType UnlockedByInteraction;
        [NMS(Index = 12)]
        /* 0xC4 */ public int UnlockedByInteractionIndex;
        [NMS(Index = 13)]
        /* 0xC8 */ public GcAlienRace UnlockedByInteractionRace;
        [NMS(Index = 10)]
        /* 0xCC */ public int UnlockedByLeveledStatRank;
        [NMS(Index = 9)]
        /* 0xD0 */ public float UnlockedByStatValue;
        [NMS(Index = 14)]
        /* 0xD4 */ public bool UnlockedByInteractionOnlyTestMainRaces;
    }
}
