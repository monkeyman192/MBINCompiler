namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3729545429FB51AE, NameHash = 0xEDAF3B07)]
    public class GcMissionConditionDeliverableStatus : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x0 */ public float DistanceThreshold;
        [NMS(Index = 2)]
        /* 0x4 */ public bool CheckDistance;
        [NMS(Index = 0)]
        /* 0x5 */ public bool CheckExists;
        [NMS(Index = 1)]
        /* 0x6 */ public bool PassIfExists;
    }
}
