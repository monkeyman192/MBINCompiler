using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4834F65934E302C5, NameHash = 0x695F3196)]
    public class GcPuzzleTextFlow : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Text;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x20A Title;
        [NMS(Index = 6)]
        /* 0x40 */ public GcAlienRace AlienLanguageOverride;
        [NMS(Index = 7)]
        /* 0x44 */ public GcAudioWwiseEvents AudioEvent;
        // size: 0x3
        public enum BracketsOverrideEnum : uint {
            None,
            Brackets,
            NoBrackets,
        }
        [NMS(Index = 5)]
        /* 0x48 */ public BracketsOverrideEnum BracketsOverride;
        [NMS(Index = 3)]
        /* 0x4C */ public GcAlienMood Mood;
        // size: 0x3
        public enum TranslateAlienTextOverrideEnum : uint {
            None,
            Translate,
            DoNotTranslate,
        }
        [NMS(Index = 4)]
        /* 0x50 */ public TranslateAlienTextOverrideEnum TranslateAlienTextOverride;
        [NMS(Index = 1)]
        /* 0x54 */ public bool IsAlien;
        [NMS(Index = 8)]
        /* 0x55 */ public bool ShowHologram;
    }
}
