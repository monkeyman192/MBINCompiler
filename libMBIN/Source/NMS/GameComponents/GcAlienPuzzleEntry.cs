using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x108, Alignment = 0x8, GUID = 0xB8B9DEF392FA498, NameHash = 0xDE1F17CE7E01A8C2)]
    public class GcAlienPuzzleEntry : NMSTemplate
    {
        /* 0x000 */ public int ProgressionIndex;
        /* 0x000 */ public int MinProgressionForSelection;
        [NMS(Size = 0x20, IDField = true)]
        /* 0x008 */ public string Id;

        /* 0x028 */ public GcAlienRace Race;
        /* 0x02C */ public GcInteractionType Type;
        /* 0x030 */ public GcAlienPuzzleCategory Category;

        public enum AdditionalOptionsEnum { None, LearnWord, SayWord }
        /* 0x034 */ public AdditionalOptionsEnum AdditionalOptions;

        [NMS(Size = 0x20)]
        /* 0x038 */ public string Title;

        [NMS(Size = 0x20)]
        /* 0x058 */ public string Text;

        [NMS(Size = 0x20)]
        /* 0x078 */ public string TextAlien;

        /* 0x098 */ public bool TranslateAlienText;
        /* 0x099 */ public bool TranslationBrackets;
        /* 0x09A */ public bool ProgressiveDialogue;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x09B */ public byte[] Padding9B;
        [NMS(Size = 0x20)]
        /* 0x0A0 */ public string RequiresScanEvent;
        /* 0x0C0 */ public List<GcAlienPuzzleOption> Options;
        /* 0x0D0 */ public List<NMSString0x20> AdditionalText;
        /* 0x0E0 */ public List<NMSString0x20> AdditionalTextAlien;
        /* 0x0F0 */ public GcAlienMood Mood;
        /* 0x0F4 */ public GcNPCPropTypes Prop;
        /* 0x0F8 */ public List<GcPuzzleTextFlow> AdvancedInteractionFlow;
    }
}
