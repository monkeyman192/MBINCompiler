namespace libMBIN.Models.Structs
{
    public class GcSmokeTestOptions : NMSTemplate
    {
        /* 0x0 */ public float InitialPause;
        /* 0x4 */ public float SmokeTestFlashTimeDuration;
        /* 0x8 */ public float CameraHeight;
        /* 0xC */ public float CameraMoveSpeed;
        /* 0x10 */ public float CameraRotateSpeed;
        /* 0x14 */ public float CameraPitchAngleDeg;
        /* 0x18 */ public bool GifMode;
        /* 0x1C */ public int GifFrames;
        /* 0x20 */ public float GifTimeBetweenKeyframes;
        /* 0x24 */ public float RegeneratePlanetFrequency;
    }
}
