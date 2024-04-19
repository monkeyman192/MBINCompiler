using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDED5B44D3B310AC9, NameHash = 0x601CD433A66F7318)]
    public class GcSettlementJudgementData : NMSTemplate
    {
        /* 0x000 */ public GcSettlementJudgementOption Option1;
        /* 0x068 */ public GcSettlementJudgementOption Option2;
        /* 0x0D0 */ public NMSString0x20A DilemmaText;
        /* 0x0F0 */ public NMSString0x20A HeaderOverride;
        /* 0x110 */ public NMSString0x20A NPC1CustomName;
        /* 0x130 */ public NMSString0x20A NPC2CustomName;
        /* 0x150 */ public NMSString0x20A NPCTitle;
        /* 0x170 */ public NMSString0x20A QuestionText;
        /* 0x190 */ public NMSString0x20A Title;
        /* 0x1B0 */ public NMSString0x10 NPC1CustomId;
        /* 0x1C0 */ public NMSString0x10 NPC1HoloEffect;
        /* 0x1D0 */ public NMSString0x10 NPC2CustomId;
        /* 0x1E0 */ public NMSString0x10 NPC2HoloEffect;
        /* 0x1F0 */ public GcSettlementJudgementType JudgementType;
        // size: 0x3
        public enum NPCsEnum : uint {
            None,
            One,
            Two,
        }
        /* 0x1F4 */ public NPCsEnum NPCs;
        /* 0x1F8 */ public float Weighting;
        /* 0x1FC */ public bool UseAltResearchLoc;
        /* 0x1FD */ public bool UseResearchLoc;
    }
}
