using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x14BCE7AB55AC06F0, NameHash = 0xDE1F17CE7E01A8C2)]
    public class GcAlienPuzzleEntry : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A Id;
        /* 0x020 */ public NMSString0x20A RequiresScanEvent;
        /* 0x040 */ public NMSString0x20A Text;
        /* 0x060 */ public NMSString0x20A TextAlien;
        /* 0x080 */ public NMSString0x20A Title;
        /* 0x0A0 */ public List<NMSString0x20A> AdditionalText;
        /* 0x0B0 */ public List<NMSString0x20A> AdditionalTextAlien;
        /* 0x0C0 */ public List<GcPuzzleTextFlow> AdvancedInteractionFlow;
        /* 0x0D0 */ public List<GcAlienPuzzleOption> Options;
        // size: 0x3
        public enum AdditionalOptionsEnum : uint {
            None,
            LearnWord,
            SayWord,
        }
        /* 0x0E0 */ public AdditionalOptionsEnum AdditionalOptions;
        /* 0x0E4 */ public GcAlienPuzzleCategory Category;
        /* 0x0E8 */ public int CustomFreighterTextIndex;
        /* 0x0EC */ public int MinProgressionForSelection;
        /* 0x0F0 */ public GcAlienMood Mood;
        /* 0x0F4 */ public GcAudioWwiseEvents NextStageAudioEventOverride;
        // size: 0x3
        public enum PersistancyBufferOverrideEnum : uint {
            None,
            AlwaysPersonal,
            AlwaysFireteam,
        }
        /* 0x0F8 */ public PersistancyBufferOverrideEnum PersistancyBufferOverride;
        /* 0x0FC */ public int ProgressionIndex;
        /* 0x100 */ public GcNPCPropType Prop;
        /* 0x104 */ public GcAlienRace Race;
        /* 0x108 */ public GcInteractionType Type;
        /* 0x10C */ public bool ProgressiveDialogue;
        /* 0x10D */ public bool RadialInteraction;
        /* 0x10E */ public bool TranslateAlienText;
        /* 0x10F */ public bool TranslationBrackets;
        /* 0x110 */ public bool UseTitleOverrideInLabel;
    }
}
