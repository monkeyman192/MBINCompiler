using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x2A8)]
    public class GcAlienPuzzleOption : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x000 */ public string Name;

        [NMS(Size = 0x200)]
        /* 0x020 */ public string Text;

        /* 0x220 */ public bool IsAlien;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x221 */ public byte[] padding221;

        [NMS(Size = 0x10)]
        /* 0x228 */ public string Cost;

        /* 0x238 */ public List<NMSString0x10> Rewards;
		public enum MoodEnum { Positive, Negative, Neutral, Pity, Dead }
		public MoodEnum Mood;

        /* 0x24C */ public bool KeepOpen;
        /* 0x24D */ public bool MarkInteractionComplete;

        [NMS(Size = 2, Ignore = true)]
        /* 0x24E */ public byte[] Padding24E;

        [NMS(Size = 0x20)]
        /* 0x250 */ public string NextInteraction;
        /* 0x270 */ public GcAudioWwiseEvents AudioEvent;
        /* 0x274 */ public GcMissionConditionTest EnablingConditionTest;
        /* 0x278 */ public List<NMSTemplate> EnablingConditions;
        [NMS(Size = 0x20)]
        /* 0x288 */ public string EnablingConditionId;
    }
}
