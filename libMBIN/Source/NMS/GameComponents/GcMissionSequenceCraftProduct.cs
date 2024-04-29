namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x61A1B3ED2A236C5C, NameHash = 0xE4A60FB879FE42CD)]
    public class GcMissionSequenceCraftProduct : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public NMSString0x20A MessageCanCraft;
        [NMS(Index = 3)]
        /* 0x020 */ public NMSString0x20A MessageLearnPreReqs;
        [NMS(Index = 2)]
        /* 0x040 */ public NMSString0x20A MessageLearnRecipe;
        [NMS(Index = 1)]
        /* 0x060 */ public NMSString0x20A MessageNoIngreds;
        [NMS(Index = 4)]
        /* 0x080 */ public NMSString0x10 TargetProductID;
        [NMS(Index = 5)]
        /* 0x090 */ public int TargetAmount;
        [NMS(Index = 10)]
        /* 0x094 */ public NMSString0x80 DebugText;
        [NMS(Index = 9)]
        /* 0x114 */ public bool CanSetIcon;
        [NMS(Index = 6)]
        /* 0x115 */ public bool TakeAmountFromSeasonData;
        [NMS(Index = 7)]
        /* 0x116 */ public bool TakeIDFromSeasonData;
        [NMS(Index = 8)]
        /* 0x117 */ public bool WaitForSelected;
    }
}
