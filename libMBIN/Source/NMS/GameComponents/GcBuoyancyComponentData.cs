namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE2881F2EE5B10A90, NameHash = 0x8728EA08)]
    public class GcBuoyancyComponentData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public float AirborneSpringTime;
        [NMS(Index = 11)]
        /* 0x04 */ public float AnchorArrivalTime;
        [NMS(Index = 12)]
        /* 0x08 */ public float MaximumAnchorForce;
        [NMS(Index = 8)]
        /* 0x0C */ public float MaximumForce;
        [NMS(Index = 7)]
        /* 0x10 */ public float MinimumForce;
        [NMS(Index = 6)]
        /* 0x14 */ public float SelfRightingStrength;
        [NMS(Index = 3)]
        /* 0x18 */ public float TargetHeightBufferFactor;
        [NMS(Index = 2)]
        /* 0x1C */ public float TargetSurfaceHeightCalm;
        [NMS(Index = 1)]
        /* 0x20 */ public float TargetSurfaceHeightRough;
        [NMS(Index = 5)]
        /* 0x24 */ public float UnderwaterSpringTime;
        [NMS(Index = 9)]
        /* 0x28 */ public float UpwardRotationFactor;
        [NMS(Index = 10)]
        /* 0x2C */ public float WaveRotationFactor;
        [NMS(Index = 0)]
        /* 0x30 */ public bool SetAnchorOnPrepare;
    }
}
