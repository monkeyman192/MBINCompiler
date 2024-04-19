namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4C8D2C5D711DF5C7, NameHash = 0xA0C253D5A5EF8A51)]
    public class TkLODSettingsData : NMSTemplate
    {
        [NMS(Size = 0x6)]
        /* 0x00 */ public int[] ImposterOverrideRange;
        [NMS(Size = 0x6)]
        /* 0x18 */ public int[] MaxObjectDistanceOverride;
        [NMS(Size = 0x6)]
        /* 0x30 */ public int[] RegionLODHiddenRanges;
        [NMS(Size = 0x6)]
        /* 0x48 */ public int[] RegionLODRadius;
        [NMS(Size = 0x5)]
        /* 0x60 */ public float[] LODAdjust;
        /* 0x74 */ public int AsteroidCountMultiplier;
        /* 0x78 */ public int AsteroidDividerMultiplier;
        /* 0x7C */ public float AsteroidFadeRangeMultiplier;
        /* 0x80 */ public int ImposterResolutionMultiplier;
        /* 0x84 */ public int MaxAsteroidGenerationPerFrame;
        /* 0x88 */ public int MaxAsteroidGenerationPerFramePulseJump;
        /* 0x8C */ public int NumberOfImposterViews;
        /* 0x90 */ public bool EnableOctahedralImposters;
        /* 0x91 */ public bool ViewImpostersFromSpace;
    }
}
