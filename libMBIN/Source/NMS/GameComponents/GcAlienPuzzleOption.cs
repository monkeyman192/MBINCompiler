using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xD8, GUID = 0x2E403B18FE44F752, NameHash = 0x3FE862FE8570BE69)]
    public class GcAlienPuzzleOption : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string Name;

        [NMS(Size = 0x20)]
        /* 0x20 */ public string Text;

        /* 0x40 */ public bool IsAlien;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x41 */ public byte[] padding41;

        [NMS(Size = 0x10)]
        /* 0x48 */ public string Cost;

        /* 0x58 */ public List<NMSString0x10> Rewards;
		/* 0x68 */ public GcAlienMood Mood;
        /* 0x6C */ public GcNPCPropTypes Prop;
        /* 0x70 */ public bool KeepOpen;
        /* 0x71 */ public bool DisplayCost;
        /* 0x72 */ public bool TruncateCost;
        /* 0x73 */ public bool MarkInteractionComplete;
        [NMS(Size = 4, Ignore = true)]
        /* 0x74 */ public byte[] Padding74;
        [NMS(Size = 0x20)]
        /* 0x78 */ public string NextInteraction;
        /* 0x98 */ public GcAudioWwiseEvents AudioEvent;
        /* 0x9C */ public GcMissionConditionTest EnablingConditionTest;
        /* 0xA0 */ public List<NMSTemplate> EnablingConditions;
        [NMS(Size = 0x20)]
        /* 0xB0 */ public string EnablingConditionId;
        /* 0xD0 */ public GcWordCategoryTableEnum WordCategory;
        [NMS(Size = 4, Ignore = true)]
        /* 0xD4 */ public byte[] EndPadding;
    }
}
