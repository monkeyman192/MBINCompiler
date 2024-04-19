namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFF9232FF9E402945, NameHash = 0x472B5C1A8B3B1505)]
    public class GcCameraShakeCapturedData : NMSTemplate
    {
        /* 0x00 */ public float ShakeFrequency;
        /* 0x04 */ public float ShakeStrength;
        /* 0x08 */ public float VibrateFrequency;
        /* 0x0C */ public float VibrateStrength;
        /* 0x10 */ public bool Active;
    }
}
