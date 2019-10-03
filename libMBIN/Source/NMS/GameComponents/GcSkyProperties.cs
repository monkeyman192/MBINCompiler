using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0xFAB9C0B6A3CF6C16, NameHash = 0xA8207C75DBE0FE33)]
    public class GcSkyProperties : NMSTemplate
    {
        /* 0x000 */ public float AtmosphereThickness;
        /* 0x004 */ public float HorizonMultiplier;
		/* 0x008 */ public float DuskHorizonMultiplier;
		/* 0x00C */ public float NightHorizonMultiplier;
		/* 0x010 */ public float HorizonFadeSpeed;
		/* 0x014 */ public float DayHorizonTightness;
		/* 0x018 */ public float SunSize;
		/* 0x01C */ public float SunStrength;
		/* 0x020 */ public float SunSurroundSize;
		/* 0x024 */ public float SunSurroundStrength;
		/* 0x028 */ public float UpperSkyFadeSpeed;
		/* 0x02C */ public float UpperSkyFadeOffset;
    }
}
