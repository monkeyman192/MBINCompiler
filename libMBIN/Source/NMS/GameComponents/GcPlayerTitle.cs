using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2A26E02A770476D8, NameHash = 0xE11E0D40)]
    public class GcPlayerTitle : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x20A AlreadyUnlockedDescription;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A Title;
        [NMS(Index = 2)]
        /* 0x40 */ public NMSString0x20A UnlockDescription;
        [NMS(Index = 15)]
        /* 0x60 */ public List<int> BlockedInSeasons;
        [NMS(Index = 0)]
        /* 0x70 */ public NMSString0x10 ID;
        [NMS(Index = 4)]
        /* 0x80 */ public NMSString0x10 RevealedBy;
        [NMS(Index = 16)]
        /* 0x90 */ public List<NMSString0x10> TitleUnlocksSpecials;
        [NMS(Index = 6)]
        /* 0xA0 */ public NMSString0x10 UnlockedByMission;
        [NMS(Index = 5)]
        /* 0xB0 */ public NMSString0x10 UnlockedByProductRecipe;
        [NMS(Index = 8)]
        /* 0xC0 */ public NMSString0x10 UnlockedByStat;
        [NMS(Index = 7)]
        /* 0xD0 */ public NMSString0x10 UnlockedByTrophy;
        [NMS(Index = 11)]
        /* 0xE0 */ public GcInteractionType UnlockedByInteraction;
        [NMS(Index = 12)]
        /* 0xE4 */ public int UnlockedByInteractionIndex;
        [NMS(Index = 13)]
        /* 0xE8 */ public GcAlienRace UnlockedByInteractionRace;
        [NMS(Index = 10)]
        /* 0xEC */ public int UnlockedByLeveledStatRank;
        [NMS(Index = 9)]
        /* 0xF0 */ public float UnlockedByStatValue;
        [NMS(Index = 14)]
        /* 0xF4 */ public bool UnlockedByInteractionOnlyTestMainRaces;
    }
}
