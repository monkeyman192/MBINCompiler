namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x71F1721071E56F5F, NameHash = 0x6FB11939)]
    public class GcGalaxyCameraData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public float CameraFOV;
        [NMS(Index = 23)]
        /* 0x04 */ public float CameraShakeDriftClip;
        [NMS(Index = 24)]
        /* 0x08 */ public float CameraShakeDriftShift;
        [NMS(Index = 26)]
        /* 0x0C */ public float CameraShakeMaximum;
        [NMS(Index = 25)]
        /* 0x10 */ public float CameraShakeSmoothingRate;
        [NMS(Index = 13)]
        /* 0x14 */ public float FreeElevationBlendRate;
        [NMS(Index = 8)]
        /* 0x18 */ public float FreePanSpeed;
        [NMS(Index = 9)]
        /* 0x1C */ public float FreePanSpeedTurbo;
        [NMS(Index = 12)]
        /* 0x20 */ public float FreeRotateSpeed;
        [NMS(Index = 10)]
        /* 0x24 */ public float FreeUpDownSpeed;
        [NMS(Index = 11)]
        /* 0x28 */ public float FreeUpDownSpeedTurbo;
        [NMS(Index = 4)]
        /* 0x2C */ public float LockTransitionRate;
        [NMS(Index = 7)]
        /* 0x30 */ public float LockedScaledElevationSpeed;
        [NMS(Index = 6)]
        /* 0x34 */ public float LockedScaledPushSpeed;
        [NMS(Index = 5)]
        /* 0x38 */ public float LockedSpinSpeed;
        [NMS(Index = 20)]
        /* 0x3C */ public float MaxZoomDistance;
        [NMS(Index = 21)]
        /* 0x40 */ public float MinPushingZoomDistance;
        [NMS(Index = 22)]
        /* 0x44 */ public float MinPushingZoomDistanceScaler;
        [NMS(Index = 19)]
        /* 0x48 */ public float MinZoomDistance;
        [NMS(Index = 1)]
        /* 0x4C */ public float MovementBlendRateFree;
        [NMS(Index = 2)]
        /* 0x50 */ public float MovementBlendRateLocked;
        [NMS(Index = 3)]
        /* 0x54 */ public float MovementBlendRateLookLocked;
        [NMS(Index = 18)]
        /* 0x58 */ public float ZoomInRate;
        [NMS(Index = 15)]
        /* 0x5C */ public float ZoomOutElevation;
        [NMS(Index = 16)]
        /* 0x60 */ public float ZoomOutPushDist;
        [NMS(Index = 17)]
        /* 0x64 */ public float ZoomOutRate;
        [NMS(Index = 14)]
        /* 0x68 */ public float ZoomOutSpin;
    }
}
