using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x210, GUID = 0x704DAEA1E9D05391, NameHash = 0xC3AAF93B598F92B7)]
    public class GcGalaxyRenderSetupData : NMSTemplate
    {
        /* 0x000 */ public Colour SunCoreColour;
        /* 0x010 */ public float SunCoreSmaller;
        /* 0x014 */ public float SunCoreLarger;
        /* 0x018 */ public float SunCoreBGContrib;
        /* 0x01C */ public float SunCoreFGContrib;
        /* 0x020 */ public float BGCellTraceScale;
        /* 0x024 */ public float BGCellMoveScale;
        /* 0x028 */ public float BGCellHorizonInfluence;
        /* 0x02C */ public float BGColourStage1;
        /* 0x030 */ public float BGColourStage2;
        /* 0x034 */ public float BGColourStage3;
        /* 0x038 */ public float BGColourStage4;
        /* 0x03C */ public float BGColourCellBlend;
        /* 0x040 */ public float BGColourPow;
        /* 0x044 */ public float StarFieldBlendAmount;
        /* 0x048 */ public float LensFlareBase;
        /* 0x050 */ public Colour LensFlareColour;
        /* 0x060 */ public Vector4f LensFlareSpread;
        /* 0x070 */ public float NebulaeAlphaPow;
        /* 0x074 */ public float NebulaeTraceValueMult;
        /* 0x078 */ public float NebulaeTraceScale;
        /* 0x07C */ public float NebulaeTraceDensity;
        /* 0x080 */ public float NebulaeTraceDensityCutoff;
        /* 0x084 */ public Vector2f NebulaeTraceStepRange;

        [NMS(Size = 4, Ignore = true)]
        /* 0x08C */ public byte[] Padding8C;

        /* 0x090 */ public Vector4f CompositionControlB_S_C_G;
        /* 0x0A0 */ public float CompositionSaturationIncreaseError;
        /* 0x0A4 */ public float CompositionSaturationIncreaseFilter;
        /* 0x0A8 */ public float CompositionSaturationIncreaseSelected;
        /* 0x0AC */ public float VignetteSize;
        /* 0x0B0 */ public float VignetteBase;
        /* 0x0B4 */ public float VignetteSizeIncreaseError;
        /* 0x0B8 */ public float VignetteSizeIncreaseFilter;
        /* 0x0BC */ public float VignetteSizeIncreaseSelected;
        /* 0x0C0 */ public Vector2f LensFlareExpandTowards;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x0C8 */ public byte[] PaddingC8;

        [NMS(Size = 0xA)]
        /* 0x0D0 */ public Colour[] MapLargeAreaPrimaryColours;
        [NMS(Size = 0xA)]
        /* 0x170 */ public Colour[] MapLargeAreaSecondaryColours;
    }
}
