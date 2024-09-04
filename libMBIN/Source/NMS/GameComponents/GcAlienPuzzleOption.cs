using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE144D593E6AF41A1, NameHash = 0x981A51EE)]
    public class GcAlienPuzzleOption : NMSTemplate
    {
        [NMS(Index = 19)]
        /* 0x00 */ public NMSString0x20A EnablingConditionId;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x20A Name;
        [NMS(Index = 13)]
        /* 0x40 */ public NMSString0x20A NextInteraction;
        [NMS(Index = 1)]
        /* 0x60 */ public NMSString0x20A Text;
        [NMS(Index = 16)]
        /* 0x80 */ public NMSString0x20A TitleOverride;
        [NMS(Index = 3)]
        /* 0xA0 */ public NMSString0x10 Cost;
        [NMS(Index = 18)]
        /* 0xB0 */ public List<NMSTemplate> EnablingConditions;
        [NMS(Index = 4)]
        /* 0xC0 */ public List<NMSString0x10> Rewards;
        [NMS(Index = 15)]
        /* 0xD0 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 17)]
        /* 0xD4 */ public GcMissionConditionTest EnablingConditionTest;
        [NMS(Index = 5)]
        /* 0xD8 */ public GcAlienMood Mood;
        [NMS(Index = 6)]
        /* 0xDC */ public GcNPCPropType Prop;
        [NMS(Index = 20)]
        /* 0xE0 */ public GcWordCategoryTableEnum WordCategory;
        [NMS(Index = 10)]
        /* 0xE4 */ public bool DisplayCost;
        [NMS(Index = 2)]
        /* 0xE5 */ public bool IsAlien;
        [NMS(Index = 9)]
        /* 0xE6 */ public bool KeepOpen;
        [NMS(Index = 12)]
        /* 0xE7 */ public bool MarkInteractionComplete;
        [NMS(Index = 7)]
        /* 0xE8 */ public bool OverrideWithAlienWord;
        [NMS(Index = 8)]
        /* 0xE9 */ public bool ReseedInteractionOnUse;
        [NMS(Index = 14)]
        /* 0xEA */ public bool SelectedOnBackOut;
        [NMS(Index = 11)]
        /* 0xEB */ public bool TruncateCost;
    }
}
