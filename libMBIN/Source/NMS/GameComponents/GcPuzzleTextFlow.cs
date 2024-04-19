using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5370598C079E49CC, NameHash = 0x44CB81CE83D73B16)]
    public class GcPuzzleTextFlow : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Text;
        /* 0x20 */ public NMSString0x20A Title;
        /* 0x40 */ public GcAlienRace AlienLanguageOverride;
        /* 0x44 */ public GcAudioWwiseEvents AudioEvent;
        // size: 0x3
        public enum BracketsOverrideEnum : uint {
            None,
            Brackets,
            NoBrackets,
        }
        /* 0x48 */ public BracketsOverrideEnum BracketsOverride;
        /* 0x4C */ public GcAlienMood Mood;
        // size: 0x3
        public enum TranslateAlienTextOverrideEnum : uint {
            None,
            Translate,
            DoNotTranslate,
        }
        /* 0x50 */ public TranslateAlienTextOverrideEnum TranslateAlienTextOverride;
        /* 0x54 */ public bool IsAlien;
        /* 0x55 */ public bool ShowHologram;
    }
}
