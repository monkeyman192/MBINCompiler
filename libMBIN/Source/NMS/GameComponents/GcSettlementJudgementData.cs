using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFF8D4C1CF1EFE995, NameHash = 0x601CD433A66F7318)]
    public class GcSettlementJudgementData : NMSTemplate
    {
        /* 0x000 */ public GcSettlementJudgementType JudgementType;
        /* 0x004 */ public float Weighting;
        /* 0x008 */ public NMSString0x20A HeaderOverride;
        /* 0x028 */ public NMSString0x20A Title;
        /* 0x048 */ public NMSString0x20A NPCTitle;
        /* 0x068 */ public NMSString0x20A QuestionText;
        /* 0x088 */ public NMSString0x20A Dilemmatext;
        /* 0x0A8 */ public bool UseResearchLoc;
        /* 0x0A9 */ public bool UseAltResearchLoc;
        /* 0x0B0 */ public GcSettlementJudgementOption Option1;
        /* 0x120 */ public GcSettlementJudgementOption Option2;
        /* 0x190 */ public NMSString0x10 NPC1CustomId;
        /* 0x1A0 */ public NMSString0x10 NPC2CustomId;
        /* 0x1B0 */ public NMSString0x20A NPC1CustomName;
        /* 0x1D0 */ public NMSString0x20A NPC2CustomName;
        /* 0x1F0 */ public NMSString0x10 NPC1HoloEffect;
        /* 0x200 */ public NMSString0x10 NPC2HoloEffect;
        public enum NPCsEnum { None, One, Two }
        /* 0x210 */ public NPCsEnum NPCs;
    }
}
