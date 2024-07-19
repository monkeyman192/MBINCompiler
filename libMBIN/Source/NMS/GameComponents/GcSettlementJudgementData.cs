using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEB07E79C7A01F374, NameHash = 0x4C3D7B42)]
    public class GcSettlementJudgementData : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x000 */ public GcSettlementJudgementOption Option1;
        [NMS(Index = 10)]
        /* 0x068 */ public GcSettlementJudgementOption Option2;
        [NMS(Index = 6)]
        /* 0x0D0 */ public NMSString0x20A DilemmaText;
        [NMS(Index = 2)]
        /* 0x0F0 */ public NMSString0x20A HeaderOverride;
        [NMS(Index = 13)]
        /* 0x110 */ public NMSString0x20A NPC1CustomName;
        [NMS(Index = 14)]
        /* 0x130 */ public NMSString0x20A NPC2CustomName;
        [NMS(Index = 4)]
        /* 0x150 */ public NMSString0x20A NPCTitle;
        [NMS(Index = 5)]
        /* 0x170 */ public NMSString0x20A QuestionText;
        [NMS(Index = 3)]
        /* 0x190 */ public NMSString0x20A Title;
        [NMS(Index = 11)]
        /* 0x1B0 */ public NMSString0x10 NPC1CustomId;
        [NMS(Index = 15)]
        /* 0x1C0 */ public NMSString0x10 NPC1HoloEffect;
        [NMS(Index = 12)]
        /* 0x1D0 */ public NMSString0x10 NPC2CustomId;
        [NMS(Index = 16)]
        /* 0x1E0 */ public NMSString0x10 NPC2HoloEffect;
        [NMS(Index = 0)]
        /* 0x1F0 */ public GcSettlementJudgementType JudgementType;
        // size: 0x3
        public enum NPCsEnum : uint {
            None,
            One,
            Two,
        }
        [NMS(Index = 17)]
        /* 0x1F4 */ public NPCsEnum NPCs;
        [NMS(Index = 1)]
        /* 0x1F8 */ public float Weighting;
        [NMS(Index = 8)]
        /* 0x1FC */ public bool UseAltResearchLoc;
        [NMS(Index = 7)]
        /* 0x1FD */ public bool UseResearchLoc;
    }
}
