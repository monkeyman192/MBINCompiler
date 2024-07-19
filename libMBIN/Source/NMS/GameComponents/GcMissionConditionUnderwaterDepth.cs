namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x24EDAF463CF6DD11, NameHash = 0x884D78C2)]
    public class GcMissionConditionUnderwaterDepth : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float Depth;
        [NMS(Index = 1)]
        /* 0x4 */ public bool TakeAmountFromSeasonData;
    }
}
