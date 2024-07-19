namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x53D933E0DAE419B4, NameHash = 0x6BA35519)]
    public class GcPlanetCloudProperties : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcSeed Seed;
        [NMS(Index = 8)]
        /* 0x10 */ public Vector2f CoverageRange;
        [NMS(Index = 7)]
        /* 0x18 */ public Vector2f CoverExtremes;
        // size: 0x2
        public enum CloudinessEnum : uint {
            CloudyWithClearSpells,
            ClearWithCloudySpells,
        }
        [NMS(Index = 12)]
        /* 0x20 */ public CloudinessEnum Cloudiness;
        [NMS(Index = 1)]
        /* 0x24 */ public float Coverage1;
        [NMS(Index = 2)]
        /* 0x28 */ public float Coverage2;
        [NMS(Index = 3)]
        /* 0x2C */ public float Coverage3;
        [NMS(Index = 4)]
        /* 0x30 */ public float Offset1;
        [NMS(Index = 5)]
        /* 0x34 */ public float Offset2;
        [NMS(Index = 6)]
        /* 0x38 */ public float Offset3;
        [NMS(Index = 10)]
        /* 0x3C */ public float RateOfChange;
        [NMS(Index = 9)]
        /* 0x40 */ public float Ratio;
        [NMS(Index = 11)]
        /* 0x44 */ public float SecondaryRateOfChange;
    }
}
