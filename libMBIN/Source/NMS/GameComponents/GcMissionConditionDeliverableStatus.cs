namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3C538D964D6206BA, NameHash = 0xEDAF3B07)]
    public class GcMissionConditionDeliverableStatus : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public VariableSizeString TextTagForCurrent;
        [NMS(Index = 6)]
        /* 0x10 */ public VariableSizeString TextTagForTarget;
        [NMS(Index = 3)]
        /* 0x20 */ public float DistanceThreshold;
        [NMS(Index = 4)]
        /* 0x24 */ public bool CheckDeliveredAll;
        [NMS(Index = 2)]
        /* 0x25 */ public bool CheckDistance;
        [NMS(Index = 0)]
        /* 0x26 */ public bool CheckExists;
        [NMS(Index = 1)]
        /* 0x27 */ public bool PassIfExists;
    }
}
