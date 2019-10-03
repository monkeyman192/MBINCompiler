using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x68, GUID = 0x1E64A8E9A44A165C, NameHash = 0x76DA44862CDF100D)]
    public class GcGalaxyCameraData : NMSTemplate
    {
        /* 0x00 */ public float CameraFOV;                      // 42C80000h
        /* 0x04 */ public float MovementBlendRateFree;          // 40400000h
        /* 0x08 */ public float MovementBlendRateLocked;        // 40A00000h
        /* 0x0C */ public float MovementBlendRateLookLocked;
        /* 0x10 */ public float LockTransitionRate;             // 40800000h
        /* 0x14 */ public float LockedSpinSpeed;                // 3F666666h
        /* 0x18 */ public float LockedScaledPushSpeed;          // 41A00000h
        /* 0x1C */ public float LockedScaledElevationSpeed;     // 43480000h
        /* 0x20 */ public float FreePanSpeed;                   // 3F800000h
        /* 0x24 */ public float FreePanSpeedTurbo;              // 40300000h
        /* 0x28 */ public float FreeUpDownSpeed;                // 41F00000h
        /* 0x2C */ public float FreeUpDownSpeedTurbo;           // 42F00000h
        /* 0x30 */ public float FreeRotateSpeed;                // 40000000h
        /* 0x34 */ public float FreeElevationBlendRate;         // 3F800000h
        /* 0x38 */ public float ZoomOutSpin;                    // 3F4CCCCDh
        /* 0x3C */ public float ZoomOutElevation;               // 0BF4CCCCDh
        /* 0x40 */ public float ZoomOutPushDist;                // 400CCCCDh
        /* 0x44 */ public float ZoomOutRate;                    // 3ECCCCCDh
        /* 0x48 */ public float ZoomInRate;                     // 40400000h
        /* 0x4C */ public float MinZoomDIstance;
        /* 0x50 */ public float MaxZoomDistance;
        /* 0x54 */ public float MinPushingZoomDistance;
        /* 0x58 */ public float CameraShakeDriftClip;           // 3E99999Ah
        /* 0x5C */ public float CameraShakeDriftShift;          // 3D4CCCCDh
        /* 0x60 */ public float CameraShakeSmoothingRate;       // 40800000h
        /* 0x64 */ public float CameraShakeMaximum;             // 3F800000h
    }
}
