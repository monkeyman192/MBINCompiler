namespace MBINCompiler.Models.Structs
{
    public class GcGalaxyRenderSetupData : NMSTemplate
    {
        public Colour SunCoreColour;
        public float SunCoreSmaller;
        public float SunCoreLarger;
        public float SunCoreBGContrib;
        public float SunCoreFGContrib;

        public float BGCellTraceScale;
        public float BGCellMoveScale;
        public float BGCellHorizonInfluence;

        public float BGColourStage1;
        public float BGColourStage2;
        public float BGColourStage3;
        public float BGColourStage4;
        public float BGColourCellBlend;
        public float BGColourPow;

        public float StarFieldBlendAmount;

        public float LensFlareBase;
        public Colour LensFlareColour;
        public Vector4f LensFlareSpread;

        public float NebulaeAlphaPow;
        public float NebulaeTraceValueMult;
        public float NebulaeTraceScale;
        public float NebulaeTraceDensity;
        public float NebulaeTraceDensityCutoff;
        public Vector2f NebulaeTraceStepRange;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding8C;

        public Vector4f CompositionControlB_S_C_G;
        public float VignetteSize;
        public float VignetteBase;
        public Vector2f LensFlareExpandTowards;

        [NMS(Size = 0xA)]
        public Colour[] MapLargeAreaPrimaryColours;
        [NMS(Size = 0xA)]
        public Colour[] MapLargeAreaSecondaryColours;
    }
}
