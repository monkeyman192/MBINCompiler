namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDDC3F5342C985F9F, NameHash = 0x40BF52C4D8757B1A)]
    public class GcCameraShakeMechanicalData : NMSTemplate
    {
        /* 0x00 */ public Vector3f ExtraShakeFrequency;
        /* 0x10 */ public Vector3f ExtraVibrateFrequency;
        /* 0x20 */ public Vector3f ShakeFrequency;
        /* 0x30 */ public Vector3f ShakeStrength;
        /* 0x40 */ public Vector3f VibrateFrequency;
        /* 0x50 */ public Vector3f VibrateStrength;
        /* 0x60 */ public bool Active;
    }
}
