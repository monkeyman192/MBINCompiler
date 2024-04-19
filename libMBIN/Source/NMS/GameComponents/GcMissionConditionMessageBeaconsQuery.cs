namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2DAF7CC6F04E7A44, NameHash = 0x7A896811854A127F)]
    public class GcMissionConditionMessageBeaconsQuery : NMSTemplate
    {
        /* 0x0 */ public int MaxPartsFound;
        /* 0x4 */ public int MinPartsFound;
        /* 0x8 */ public float SearchDistanceLimit;
    }
}
