namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5CD7D5D997F3D884, NameHash = 0x26A6F412)]
    public class GcCameraShakeMechanicalData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public Vector3f ExtraShakeFrequency;
        [NMS(Index = 6)]
        /* 0x10 */ public Vector3f ExtraVibrateFrequency;
        [NMS(Index = 2)]
        /* 0x20 */ public Vector3f ShakeFrequency;
        [NMS(Index = 1)]
        /* 0x30 */ public Vector3f ShakeStrength;
        [NMS(Index = 5)]
        /* 0x40 */ public Vector3f VibrateFrequency;
        [NMS(Index = 4)]
        /* 0x50 */ public Vector3f VibrateStrength;
        [NMS(Index = 0)]
        /* 0x60 */ public bool Active;
    }
}
