namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3E5803332860AF5F, NameHash = 0x5EDEDF6E)]
    public class TkDynamicTreeWindFrequency : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public float BranchHForcePeriod;
        [NMS(Index = 3)]
        /* 0x04 */ public float BranchHForcePeriodFast;
        [NMS(Index = 0)]
        /* 0x08 */ public float BranchVForcePeriod;
        [NMS(Index = 1)]
        /* 0x0C */ public float BranchVForcePeriodFast;
        [NMS(Index = 4)]
        /* 0x10 */ public float LeafForcePeriod;
        [NMS(Index = 5)]
        /* 0x14 */ public float LeafForcePeriodFast;
        [NMS(Index = 6)]
        /* 0x18 */ public float LeafNoiseSpeed;
        [NMS(Index = 7)]
        /* 0x1C */ public float LeafNoiseSpeedFast;
    }
}
