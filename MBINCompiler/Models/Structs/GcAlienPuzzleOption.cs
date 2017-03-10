using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcAlienPuzzleOption : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x000 */ public string Name;

        [NMS(Size = 0x200)]
        /* 0x020 */ public string Text;

        [NMS(Size = 0x10)]
        /* 0x220 */ public string Cost;

        /* 0x230 */ public List<NMSString0x10> Rewards;
        /* 0x240 */ public int Mood;
        public string[] MoodValues()
        {
            return new[] { "Positive", "Negative", "Neutral", "Pity" };
        }

        /* 0x244 */ public bool KeepOpen;
        /* 0x245 */ public bool MarkInteractionComplete;

        [NMS(Size = 2, Ignore = true)]
        public byte[] Padding;
    }
}
