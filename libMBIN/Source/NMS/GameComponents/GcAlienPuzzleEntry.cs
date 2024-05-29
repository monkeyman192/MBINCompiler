using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE3C5249B0F356BD2, NameHash = 0xDE1F17CE7E01A8C2)]
    public class GcAlienPuzzleEntry : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public NMSString0x20A Id;
        [NMS(Index = 13)]
        /* 0x020 */ public NMSString0x20A RequiresScanEvent;
        [NMS(Index = 8)]
        /* 0x040 */ public NMSString0x20A Text;
        [NMS(Index = 9)]
        /* 0x060 */ public NMSString0x20A TextAlien;
        [NMS(Index = 7)]
        /* 0x080 */ public NMSString0x20A Title;
        [NMS(Index = 15)]
        /* 0x0A0 */ public List<NMSString0x20A> AdditionalText;
        [NMS(Index = 16)]
        /* 0x0B0 */ public List<NMSString0x20A> AdditionalTextAlien;
        [NMS(Index = 19)]
        /* 0x0C0 */ public List<GcPuzzleTextFlow> AdvancedInteractionFlow;
        [NMS(Index = 14)]
        /* 0x0D0 */ public List<GcAlienPuzzleOption> Options;
        // size: 0x3
        public enum AdditionalOptionsEnum : uint {
            None,
            LearnWord,
            SayWord,
        }
        [NMS(Index = 6)]
        /* 0x0E0 */ public AdditionalOptionsEnum AdditionalOptions;
        [NMS(Index = 5)]
        /* 0x0E4 */ public GcAlienPuzzleCategory Category;
        [NMS(Index = 21)]
        /* 0x0E8 */ public int CustomFreighterTextIndex;
        [NMS(Index = 1)]
        /* 0x0EC */ public int MinProgressionForSelection;
        [NMS(Index = 17)]
        /* 0x0F0 */ public GcAlienMood Mood;
        [NMS(Index = 24)]
        /* 0x0F4 */ public GcAudioWwiseEvents NextStageAudioEventOverride;
        // size: 0x3
        public enum PersistancyBufferOverrideEnum : uint {
            None,
            AlwaysPersonal,
            AlwaysFireteam,
        }
        [NMS(Index = 20)]
        /* 0x0F8 */ public PersistancyBufferOverrideEnum PersistancyBufferOverride;
        [NMS(Index = 0)]
        /* 0x0FC */ public int ProgressionIndex;
        [NMS(Index = 18)]
        /* 0x100 */ public GcNPCPropType Prop;
        [NMS(Index = 3)]
        /* 0x104 */ public GcAlienRace Race;
        [NMS(Index = 4)]
        /* 0x108 */ public GcInteractionType Type;
        [NMS(Index = 12)]
        /* 0x10C */ public bool ProgressiveDialogue;
        [NMS(Index = 22)]
        /* 0x10D */ public bool RadialInteraction;
        [NMS(Index = 10)]
        /* 0x10E */ public bool TranslateAlienText;
        [NMS(Index = 11)]
        /* 0x10F */ public bool TranslationBrackets;
        [NMS(Index = 23)]
        /* 0x110 */ public bool UseTitleOverrideInLabel;
    }
}
