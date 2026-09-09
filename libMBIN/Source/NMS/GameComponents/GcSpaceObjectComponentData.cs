namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4AE6FF8BBD0D99B6, NameHash = 0xF93891B6)]
    public class GcSpaceObjectComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public float MaxSpeedLimitRadius;
        [NMS(Index = 2)]
        /* 0x04 */ public float MinSpeedLimitRadius;
        [NMS(Index = 4)]
        /* 0x08 */ public float SpeedLimitBoostSpeed;
        [NMS(Index = 6)]
        /* 0x0C */ public float SpeedLimitFacingAwayAngle;
        [NMS(Index = 7)]
        /* 0x10 */ public float SpeedLimitFacingRelease;
        [NMS(Index = 5)]
        /* 0x14 */ public float SpeedLimitFacingTowardsAngle;
        [NMS(Index = 3)]
        /* 0x18 */ public float SpeedLimitSpeed;
        [NMS(Index = 0)]
        /* 0x1C */ public bool ApplySpeedLimit;
    }
}
