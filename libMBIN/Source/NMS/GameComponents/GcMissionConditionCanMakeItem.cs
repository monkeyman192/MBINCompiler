namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x998B3898D487FCAB, NameHash = 0xEBB70B97E46B3143)]
    public class GcMissionConditionCanMakeItem : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 TargetItem;
        [NMS(Index = 1)]
        /* 0x10 */ public int Amount;
    }
}
