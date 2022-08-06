using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x4E4FDD440BD74765, NameHash = 0x1A9F7FA6E4ED2B3E)]
    public class GcSmokeTestOptions : NMSTemplate
    {
        /* 0x00 */ public float InitialPause;
        /* 0x04 */ public float SmokeTestFlashTimeDuration;
        /* 0x08 */ public float CameraHeight;
        /* 0x0C */ public float CameraFastHeight;
        /* 0x10 */ public float CameraMoveSpeed;
        /* 0x14 */ public float CameraFastMoveSpeed;
        /* 0x18 */ public float CameraRotateSpeed;
        /* 0x1C */ public float CameraPitchAngleDeg;
        /* 0x20 */ public float CameraPitchSpeedRange;
        /* 0x24 */ public bool GifMode;
        /* 0x28 */ public int GifFrames;
        /* 0x2C */ public float GifTimeBetweenKeyframes;
        /* 0x30 */ public float PlanetFlightTime;
        /* 0x34 */ public float PlanetFlightTimeout;
        /* 0x38 */ public float SmokeBotTurnAngle;
        /* 0x3C */ public int SmokeBotNumWalksBeforeWarp;
    }
}
