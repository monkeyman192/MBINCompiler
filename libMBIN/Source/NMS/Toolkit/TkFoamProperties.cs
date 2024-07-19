namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x5F368615EF2850CA, NameHash = 0x5A088BDF)]
    public class TkFoamProperties : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public float FoamBlurFactor;
        [NMS(Index = 1)]
        /* 0x04 */ public float FoamFadeRate;
        [NMS(Index = 5)]
        /* 0x08 */ public float ShorelineFoamFadeDepth;
        [NMS(Index = 6)]
        /* 0x0C */ public float ShorelineFoamMidpointDepth;
        [NMS(Index = 7)]
        /* 0x10 */ public float ShorelineFoamSaturateDepth;
        [NMS(Index = 2)]
        /* 0x14 */ public float WaveFoamBase;
        [NMS(Index = 4)]
        /* 0x18 */ public float WaveFoamGenerationStrength;
        [NMS(Index = 3)]
        /* 0x1C */ public float WaveFoamSensitivity;
    }
}
