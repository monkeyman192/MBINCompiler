namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9F922C89C96A1B4F, NameHash = 0x96E42AD217EA55B2)]
    public class GcPlanetCloudProperties : NMSTemplate
    {
        /* 0x00 */ public GcSeed Seed;
        /* 0x10 */ public Vector2f CoverExtremes;
        // size: 0x2
        public enum CloudinessEnum : uint {
            CloudyWithClearSpells,
            ClearWithCloudySpells,
        }
        /* 0x18 */ public CloudinessEnum Cloudiness;
        /* 0x1C */ public float Coverage1;
        /* 0x20 */ public float Coverage2;
        /* 0x24 */ public float Coverage3;
        /* 0x28 */ public float Offset1;
        /* 0x2C */ public float Offset2;
        /* 0x30 */ public float Offset3;
        /* 0x34 */ public float RateOfChange;
        /* 0x38 */ public float Ratio;
        /* 0x3C */ public float SecondaryRateOfChange;
    }
}
