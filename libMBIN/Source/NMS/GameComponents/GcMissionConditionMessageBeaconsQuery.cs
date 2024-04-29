namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2B0B4E57839535EE, NameHash = 0x7A896811854A127F)]
    public class GcMissionConditionMessageBeaconsQuery : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int MaxPartsFound;
        [NMS(Index = 0)]
        /* 0x4 */ public int MinPartsFound;
        [NMS(Index = 2)]
        /* 0x8 */ public float SearchDistanceLimit;
    }
}
