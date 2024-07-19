namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2581E4BED7B799BE, NameHash = 0xDBC579DA)]
    public class GcGalaxyRenderSetupData : NMSTemplate
    {
        [NMS(Index = 34, Size = 0xA)]
        /* 0x000 */ public Colour[] MapLargeAreaPrimaryDefaultColours;
        [NMS(Index = 35, Size = 0xA)]
        /* 0x0A0 */ public Colour[] MapLargeAreaPrimaryHighContrastColours;
        [NMS(Index = 36, Size = 0xA)]
        /* 0x140 */ public Colour[] MapLargeAreaSecondaryDefaultColours;
        [NMS(Index = 37, Size = 0xA)]
        /* 0x1E0 */ public Colour[] MapLargeAreaSecondaryHighContrastColours;
        [NMS(Index = 24)]
        /* 0x280 */ public Vector4f CompositionControlB_S_C_G;
        [NMS(Index = 16)]
        /* 0x290 */ public Colour LensFlareColour;
        [NMS(Index = 17)]
        /* 0x2A0 */ public Vector4f LensFlareSpread;
        [NMS(Index = 0)]
        /* 0x2B0 */ public Colour SunCoreColour;
        [NMS(Index = 33)]
        /* 0x2C0 */ public Vector2f LensFlareExpandTowards;
        [NMS(Index = 23)]
        /* 0x2C8 */ public Vector2f NebulaeTraceStepRange;
        [NMS(Index = 7)]
        /* 0x2D0 */ public float BGCellHorizonInfluence;
        [NMS(Index = 6)]
        /* 0x2D4 */ public float BGCellMoveScale;
        [NMS(Index = 5)]
        /* 0x2D8 */ public float BGCellTraceScale;
        [NMS(Index = 12)]
        /* 0x2DC */ public float BGColourCellBlend;
        [NMS(Index = 13)]
        /* 0x2E0 */ public float BGColourPow;
        [NMS(Index = 8)]
        /* 0x2E4 */ public float BGColourStage1;
        [NMS(Index = 9)]
        /* 0x2E8 */ public float BGColourStage2;
        [NMS(Index = 10)]
        /* 0x2EC */ public float BGColourStage3;
        [NMS(Index = 11)]
        /* 0x2F0 */ public float BGColourStage4;
        [NMS(Index = 25)]
        /* 0x2F4 */ public float CompositionSaturationIncreaseError;
        [NMS(Index = 26)]
        /* 0x2F8 */ public float CompositionSaturationIncreaseFilter;
        [NMS(Index = 27)]
        /* 0x2FC */ public float CompositionSaturationIncreaseSelected;
        [NMS(Index = 15)]
        /* 0x300 */ public float LensFlareBase;
        [NMS(Index = 18)]
        /* 0x304 */ public float NebulaeAlphaPow;
        [NMS(Index = 21)]
        /* 0x308 */ public float NebulaeTraceDensity;
        [NMS(Index = 22)]
        /* 0x30C */ public float NebulaeTraceDensityCutoff;
        [NMS(Index = 20)]
        /* 0x310 */ public float NebulaeTraceScale;
        [NMS(Index = 19)]
        /* 0x314 */ public float NebulaeTraceValueMult;
        [NMS(Index = 14)]
        /* 0x318 */ public float StarFieldBlendAmount;
        [NMS(Index = 3)]
        /* 0x31C */ public float SunCoreBGContrib;
        [NMS(Index = 4)]
        /* 0x320 */ public float SunCoreFGContrib;
        [NMS(Index = 2)]
        /* 0x324 */ public float SunCoreLarger;
        [NMS(Index = 1)]
        /* 0x328 */ public float SunCoreSmaller;
        [NMS(Index = 29)]
        /* 0x32C */ public float VignetteBase;
        [NMS(Index = 28)]
        /* 0x330 */ public float VignetteSize;
        [NMS(Index = 30)]
        /* 0x334 */ public float VignetteSizeIncreaseError;
        [NMS(Index = 31)]
        /* 0x338 */ public float VignetteSizeIncreaseFilter;
        [NMS(Index = 32)]
        /* 0x33C */ public float VignetteSizeIncreaseSelected;
    }
}
