namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4935C058DDB98084, NameHash = 0xC3AAF93B598F92B7)]
    public class GcGalaxyRenderSetupData : NMSTemplate
    {
        [NMS(Size = 0xA)]
        /* 0x000 */ public Colour[] MapLargeAreaPrimaryDefaultColours;
        [NMS(Size = 0xA)]
        /* 0x0A0 */ public Colour[] MapLargeAreaPrimaryHighContrastColours;
        [NMS(Size = 0xA)]
        /* 0x140 */ public Colour[] MapLargeAreaSecondaryDefaultColours;
        [NMS(Size = 0xA)]
        /* 0x1E0 */ public Colour[] MapLargeAreaSecondaryHighContrastColours;
        /* 0x280 */ public Vector4f CompositionControlB_S_C_G;
        /* 0x290 */ public Colour LensFlareColour;
        /* 0x2A0 */ public Vector4f LensFlareSpread;
        /* 0x2B0 */ public Colour SunCoreColour;
        /* 0x2C0 */ public Vector2f LensFlareExpandTowards;
        /* 0x2C8 */ public Vector2f NebulaeTraceStepRange;
        /* 0x2D0 */ public float BGCellHorizonInfluence;
        /* 0x2D4 */ public float BGCellMoveScale;
        /* 0x2D8 */ public float BGCellTraceScale;
        /* 0x2DC */ public float BGColourCellBlend;
        /* 0x2E0 */ public float BGColourPow;
        /* 0x2E4 */ public float BGColourStage1;
        /* 0x2E8 */ public float BGColourStage2;
        /* 0x2EC */ public float BGColourStage3;
        /* 0x2F0 */ public float BGColourStage4;
        /* 0x2F4 */ public float CompositionSaturationIncreaseError;
        /* 0x2F8 */ public float CompositionSaturationIncreaseFilter;
        /* 0x2FC */ public float CompositionSaturationIncreaseSelected;
        /* 0x300 */ public float LensFlareBase;
        /* 0x304 */ public float NebulaeAlphaPow;
        /* 0x308 */ public float NebulaeTraceDensity;
        /* 0x30C */ public float NebulaeTraceDensityCutoff;
        /* 0x310 */ public float NebulaeTraceScale;
        /* 0x314 */ public float NebulaeTraceValueMult;
        /* 0x318 */ public float StarFieldBlendAmount;
        /* 0x31C */ public float SunCoreBGContrib;
        /* 0x320 */ public float SunCoreFGContrib;
        /* 0x324 */ public float SunCoreLarger;
        /* 0x328 */ public float SunCoreSmaller;
        /* 0x32C */ public float VignetteBase;
        /* 0x330 */ public float VignetteSize;
        /* 0x334 */ public float VignetteSizeIncreaseError;
        /* 0x338 */ public float VignetteSizeIncreaseFilter;
        /* 0x33C */ public float VignetteSizeIncreaseSelected;
    }
}
