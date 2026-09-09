using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA2CCECAA20749172, NameHash = 0x981A51EE)]
    public class GcAlienPuzzleOption : NMSTemplate
    {
        [NMS(Index = 22)]
        /* 0x00 */ public NMSString0x20A DisablingConditionId;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x20A Name;
        [NMS(Index = 15)]
        /* 0x40 */ public NMSString0x20A NextInteraction;
        [NMS(Index = 1)]
        /* 0x60 */ public NMSString0x20A Text;
        [NMS(Index = 18)]
        /* 0x80 */ public NMSString0x20A TitleOverride;
        [NMS(Index = 4)]
        /* 0xA0 */ public NMSString0x10 Cost;
        [NMS(Index = 21)]
        /* 0xB0 */ public List<NMSTemplate> DisablingConditions;
        [NMS(Index = 5)]
        /* 0xC0 */ public List<NMSString0x10> Rewards;
        [NMS(Index = 9)]
        /* 0xD0 */ public GcAlienRace AlienWordSpecificRace;
        [NMS(Index = 17)]
        /* 0xD4 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 20)]
        /* 0xD8 */ public GcMissionConditionTest DisablingConditionTest;
        [NMS(Index = 6)]
        /* 0xDC */ public GcAlienMood Mood;
        [NMS(Index = 7)]
        /* 0xE0 */ public GcNPCPropType Prop;
        [NMS(Index = 3)]
        /* 0xE4 */ public GcAlienRace ResponseLanguageOverride;
        [NMS(Index = 23)]
        /* 0xE8 */ public GcWordCategoryTableEnum WordCategory;
        [NMS(Index = 12)]
        /* 0xEC */ public bool DisplayCost;
        [NMS(Index = 2)]
        /* 0xED */ public bool IsAlien;
        [NMS(Index = 11)]
        /* 0xEE */ public bool KeepOpen;
        [NMS(Index = 14)]
        /* 0xEF */ public bool MarkInteractionComplete;
        [NMS(Index = 8)]
        /* 0xF0 */ public bool OverrideWithAlienWord;
        [NMS(Index = 10)]
        /* 0xF1 */ public bool ReseedInteractionOnUse;
        [NMS(Index = 16)]
        /* 0xF2 */ public bool SelectedOnBackOut;
        [NMS(Index = 19)]
        /* 0xF3 */ public bool SkipStraightToOptionsOnNextPuzzle;
        [NMS(Index = 13)]
        /* 0xF4 */ public bool TruncateCost;
    }
}
