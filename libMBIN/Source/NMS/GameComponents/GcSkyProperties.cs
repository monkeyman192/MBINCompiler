namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAA0EB553E5929CD4, NameHash = 0xA8207C75DBE0FE33)]
    public class GcSkyProperties : NMSTemplate
    {
        /* 0x00 */ public float AtmosphereThickness;
        /* 0x04 */ public float DayHorizonTightness;
        /* 0x08 */ public float DuskHorizonMultiplier;
        /* 0x0C */ public float HorizonFadeSpeed;
        /* 0x10 */ public float HorizonMultiplier;
        /* 0x14 */ public float NightHorizonMultiplier;
        /* 0x18 */ public float SunSize;
        /* 0x1C */ public float SunStrength;
        /* 0x20 */ public float SunSurroundSize;
        /* 0x24 */ public float SunSurroundStrength;
        /* 0x28 */ public float UpperSkyFadeOffset;
        /* 0x2C */ public float UpperSkyFadeSpeed;
    }
}
