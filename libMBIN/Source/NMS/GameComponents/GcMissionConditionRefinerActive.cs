namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD73F36F557B264E8, NameHash = 0x1B95D5FDE04FECD9)]
    public class GcMissionConditionRefinerActive : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A ActiveRecipe;
        /* 0x20 */ public int AmountToMake;
        /* 0x24 */ public bool HasFuel;
    }
}
