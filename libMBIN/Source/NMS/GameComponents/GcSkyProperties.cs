namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAA0EB553E5929CD4, NameHash = 0xA8207C75DBE0FE33)]
    public class GcSkyProperties : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public float AtmosphereThickness;
        [NMS(Index = 5)]
        /* 0x04 */ public float DayHorizonTightness;
        [NMS(Index = 2)]
        /* 0x08 */ public float DuskHorizonMultiplier;
        [NMS(Index = 4)]
        /* 0x0C */ public float HorizonFadeSpeed;
        [NMS(Index = 1)]
        /* 0x10 */ public float HorizonMultiplier;
        [NMS(Index = 3)]
        /* 0x14 */ public float NightHorizonMultiplier;
        [NMS(Index = 6)]
        /* 0x18 */ public float SunSize;
        [NMS(Index = 7)]
        /* 0x1C */ public float SunStrength;
        [NMS(Index = 8)]
        /* 0x20 */ public float SunSurroundSize;
        [NMS(Index = 9)]
        /* 0x24 */ public float SunSurroundStrength;
        [NMS(Index = 11)]
        /* 0x28 */ public float UpperSkyFadeOffset;
        [NMS(Index = 10)]
        /* 0x2C */ public float UpperSkyFadeSpeed;
    }
}
