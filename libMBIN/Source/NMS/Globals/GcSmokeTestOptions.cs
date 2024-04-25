namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xEC91040F8A270DB4, NameHash = 0x1A9F7FA6E4ED2B3E)]
    public class GcSmokeTestOptions : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public float CameraFastHeight;
        [NMS(Index = 5)]
        /* 0x04 */ public float CameraFastMoveSpeed;
        [NMS(Index = 2)]
        /* 0x08 */ public float CameraHeight;
        [NMS(Index = 4)]
        /* 0x0C */ public float CameraMoveSpeed;
        [NMS(Index = 7)]
        /* 0x10 */ public float CameraPitchAngleDeg;
        [NMS(Index = 8)]
        /* 0x14 */ public float CameraPitchSpeedRange;
        [NMS(Index = 6)]
        /* 0x18 */ public float CameraRotateSpeed;
        [NMS(Index = 10)]
        /* 0x1C */ public int GifFrames;
        [NMS(Index = 11)]
        /* 0x20 */ public float GifTimeBetweenKeyframes;
        [NMS(Index = 0)]
        /* 0x24 */ public float InitialPause;
        [NMS(Index = 12)]
        /* 0x28 */ public float PlanetFlightTime;
        [NMS(Index = 13)]
        /* 0x2C */ public float PlanetFlightTimeout;
        [NMS(Index = 15)]
        /* 0x30 */ public int SmokeBotNumWalksBeforeWarp;
        [NMS(Index = 14)]
        /* 0x34 */ public float SmokeBotTurnAngle;
        [NMS(Index = 1)]
        /* 0x38 */ public float SmokeTestFlashTimeDuration;
        [NMS(Index = 9)]
        /* 0x3C */ public bool GifMode;
    }
}
