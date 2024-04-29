namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x72822AA1C4D21842, NameHash = 0xA0C253D5A5EF8A51)]
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
        [NMS(Index = 9)]
        /* 0x74 */ public int AsteroidCountMultiplier;
        [NMS(Index = 10)]
        /* 0x78 */ public int AsteroidDividerMultiplier;
        [NMS(Index = 11)]
        /* 0x7C */ public float AsteroidFadeRangeMultiplier;
        [NMS(Index = 8)]
        /* 0x80 */ public int ImposterResolutionMultiplier;
        [NMS(Index = 12)]
        /* 0x84 */ public int MaxAsteroidGenerationPerFrame;
        [NMS(Index = 13)]
        /* 0x88 */ public int MaxAsteroidGenerationPerFramePulseJump;
        [NMS(Index = 7)]
        /* 0x8C */ public int NumberOfImposterViews;
        [NMS(Index = 5)]
        /* 0x90 */ public bool EnableOctahedralImposters;
        [NMS(Index = 6)]
        /* 0x91 */ public bool ViewImpostersFromSpace;
    }
}
