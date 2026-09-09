namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCC2E5A8FC78B2B2C, NameHash = 0x6805DF13)]
    public class TkLODSettingsData : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x6)]
        /* 0x00 */ public int[] ImposterOverrideRange;
        [NMS(Index = 2, Size = 0x6)]
        /* 0x18 */ public int[] MaxObjectDistanceOverride;
        [NMS(Index = 3, Size = 0x6)]
        /* 0x30 */ public int[] RegionLODHiddenRanges;
        [NMS(Index = 4, Size = 0x6)]
        /* 0x48 */ public int[] RegionLODRadius;
        [NMS(Index = 0, Size = 0x5)]
        /* 0x60 */ public float[] LODAdjust;
        [NMS(Index = 7)]
        /* 0x74 */ public int AsteroidCountMultiplier;
        [NMS(Index = 8)]
        /* 0x78 */ public int AsteroidDividerMultiplier;
        [NMS(Index = 9)]
        /* 0x7C */ public int MaxAsteroidGenerationPerFrame;
        [NMS(Index = 10)]
        /* 0x80 */ public int MaxAsteroidGenerationPerFramePulseJump;
        [NMS(Index = 6)]
        /* 0x84 */ public int NumberOfImposterViews;
        [NMS(Index = 5)]
        /* 0x88 */ public bool ViewImpostersFromSpace;
    }
}
