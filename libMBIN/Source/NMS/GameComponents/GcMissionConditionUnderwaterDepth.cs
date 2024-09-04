namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA359F19F90029DE4, NameHash = 0x884D78C2)]
    public class GcMissionConditionUnderwaterDepth : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float Depth;
        [NMS(Index = 2)]
        /* 0x4 */ public bool InBaseCanCountAsUnderwater;
        [NMS(Index = 1)]
        /* 0x5 */ public bool TakeAmountFromSeasonData;
    }
}
