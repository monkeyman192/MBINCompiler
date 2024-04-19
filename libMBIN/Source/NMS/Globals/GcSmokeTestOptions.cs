namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xEC91040F8A270DB4, NameHash = 0x1A9F7FA6E4ED2B3E)]
    public class GcSmokeTestOptions : NMSTemplate
    {
        /* 0x00 */ public float CameraFastHeight;
        /* 0x04 */ public float CameraFastMoveSpeed;
        /* 0x08 */ public float CameraHeight;
        /* 0x0C */ public float CameraMoveSpeed;
        /* 0x10 */ public float CameraPitchAngleDeg;
        /* 0x14 */ public float CameraPitchSpeedRange;
        /* 0x18 */ public float CameraRotateSpeed;
        /* 0x1C */ public int GifFrames;
        /* 0x20 */ public float GifTimeBetweenKeyframes;
        /* 0x24 */ public float InitialPause;
        /* 0x28 */ public float PlanetFlightTime;
        /* 0x2C */ public float PlanetFlightTimeout;
        /* 0x30 */ public int SmokeBotNumWalksBeforeWarp;
        /* 0x34 */ public float SmokeBotTurnAngle;
        /* 0x38 */ public float SmokeTestFlashTimeDuration;
        /* 0x3C */ public bool GifMode;
    }
}
