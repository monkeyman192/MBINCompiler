namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x27DD5057D4EAD44C, NameHash = 0x10FCB49CBC61F8AA)]
    public class GcWeatherHazardTornadoData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public float SuckInRadius;
        [NMS(Index = 1)]
        /* 0x04 */ public float SuckInStrength;
        [NMS(Index = 4)]
        /* 0x08 */ public float SuckUpHeight;
        [NMS(Index = 5)]
        /* 0x0C */ public float SuckUpHeightCutoff;
        [NMS(Index = 2)]
        /* 0x10 */ public float SuckUpRadius;
        [NMS(Index = 3)]
        /* 0x14 */ public float SuckUpStrength;
    }
}
