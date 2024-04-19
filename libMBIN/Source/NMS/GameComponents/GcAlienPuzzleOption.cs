using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x43CF4109122236CC, NameHash = 0x3FE862FE8570BE69)]
    public class GcAlienPuzzleOption : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A EnablingConditionId;
        /* 0x20 */ public NMSString0x20A Name;
        /* 0x40 */ public NMSString0x20A NextInteraction;
        /* 0x60 */ public NMSString0x20A Text;
        /* 0x80 */ public NMSString0x20A TitleOverride;
        /* 0xA0 */ public NMSString0x10 Cost;
        /* 0xB0 */ public List<NMSTemplate> EnablingConditions;
        /* 0xC0 */ public List<NMSString0x10> Rewards;
        /* 0xD0 */ public GcAudioWwiseEvents AudioEvent;
        /* 0xD4 */ public GcMissionConditionTest EnablingConditionTest;
        /* 0xD8 */ public GcAlienMood Mood;
        /* 0xDC */ public GcNPCPropType Prop;
        /* 0xE0 */ public GcWordCategoryTableEnum WordCategory;
        /* 0xE4 */ public bool DisplayCost;
        /* 0xE5 */ public bool IsAlien;
        /* 0xE6 */ public bool KeepOpen;
        /* 0xE7 */ public bool MarkInteractionComplete;
        /* 0xE8 */ public bool OverrideWithAlienWord;
        /* 0xE9 */ public bool ReseedInteractionOnUse;
        /* 0xEA */ public bool SelectedOnBackOut;
        /* 0xEB */ public bool TruncateCost;
    }
}
