namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD3A927AFE0D717C5, NameHash = 0xE4A60FB879FE42CD)]
    public class GcMissionSequenceCraftProduct : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A MessageCanCraft;
        /* 0x020 */ public NMSString0x20A MessageLearnPreReqs;
        /* 0x040 */ public NMSString0x20A MessageLearnRecipe;
        /* 0x060 */ public NMSString0x20A MessageNoIngreds;
        /* 0x080 */ public NMSString0x10 TargetProductID;
        /* 0x090 */ public int TargetAmount;
        /* 0x094 */ public NMSString0x80 DebugText;
        /* 0x114 */ public bool CanSetIcon;
        /* 0x115 */ public bool TakeAmountFromSeasonData;
        /* 0x116 */ public bool TakeIDFromSeasonData;
        /* 0x117 */ public bool WaitForSelected;
    }
}
