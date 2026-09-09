using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4DB33BA8B98926EF, NameHash = 0x695F3196)]
    public class GcPuzzleTextFlow : NMSTemplate
    {
        [NMS(Index = 12)]
        /* 0x00 */ public NMSString0x20A DisablingConditionId;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x20A Text;
        [NMS(Index = 3)]
        /* 0x40 */ public NMSString0x20A Title;
        [NMS(Index = 11)]
        /* 0x60 */ public List<NMSTemplate> DisablingConditions;
        [NMS(Index = 7)]
        /* 0x70 */ public GcAlienRace AlienLanguageOverride;
        [NMS(Index = 8)]
        /* 0x74 */ public GcAudioWwiseEvents AudioEvent;
        // size: 0x3
        public enum BracketsOverrideEnum : uint {
            None,
            Brackets,
            NoBrackets,
        }
        [NMS(Index = 6)]
        /* 0x78 */ public BracketsOverrideEnum BracketsOverride;
        [NMS(Index = 10)]
        /* 0x7C */ public GcMissionConditionTest DisablingConditionTest;
        [NMS(Index = 4)]
        /* 0x80 */ public GcAlienMood Mood;
        // size: 0x3
        public enum TranslateAlienTextOverrideEnum : uint {
            None,
            Translate,
            DoNotTranslate,
        }
        [NMS(Index = 5)]
        /* 0x84 */ public TranslateAlienTextOverrideEnum TranslateAlienTextOverride;
        [NMS(Index = 1)]
        /* 0x88 */ public bool AutoVaryText;
        [NMS(Index = 2)]
        /* 0x89 */ public bool IsAlien;
        [NMS(Index = 9)]
        /* 0x8A */ public bool ShowHologram;
    }
}
