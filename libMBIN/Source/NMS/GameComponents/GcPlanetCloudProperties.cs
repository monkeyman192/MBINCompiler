namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9F922C89C96A1B4F, NameHash = 0x96E42AD217EA55B2)]
    public class GcPlanetCloudProperties : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcSeed Seed;
        [NMS(Index = 7)]
        /* 0x10 */ public Vector2f CoverExtremes;
        // size: 0x2
        public enum CloudinessEnum : uint {
            CloudyWithClearSpells,
            ClearWithCloudySpells,
        }
        [NMS(Index = 11)]
        /* 0x18 */ public CloudinessEnum Cloudiness;
        [NMS(Index = 1)]
        /* 0x1C */ public float Coverage1;
        [NMS(Index = 2)]
        /* 0x20 */ public float Coverage2;
        [NMS(Index = 3)]
        /* 0x24 */ public float Coverage3;
        [NMS(Index = 4)]
        /* 0x28 */ public float Offset1;
        [NMS(Index = 5)]
        /* 0x2C */ public float Offset2;
        [NMS(Index = 6)]
        /* 0x30 */ public float Offset3;
        [NMS(Index = 9)]
        /* 0x34 */ public float RateOfChange;
        [NMS(Index = 8)]
        /* 0x38 */ public float Ratio;
        [NMS(Index = 10)]
        /* 0x3C */ public float SecondaryRateOfChange;
    }
}
