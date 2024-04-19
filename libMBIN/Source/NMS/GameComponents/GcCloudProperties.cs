namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xACC78F5C88ED57CC, NameHash = 0x21C58A0DDEF4EC87)]
    public class GcCloudProperties : NMSTemplate
    {
        /* 0x00 */ public Colour CloudBaseColour;
        /* 0x10 */ public Vector4f CloudHeightGradient1;
        /* 0x20 */ public Vector4f CloudHeightGradient2;
        /* 0x30 */ public Vector4f CloudHeightGradient3;
        /* 0x40 */ public Colour CloudTopColour;
        /* 0x50 */ public Vector2f StratosphereWindOffset;
        /* 0x58 */ public Vector2f WindOffset;
        /* 0x60 */ public float AmbientDensity;
        /* 0x64 */ public float AmbientScalar;
        /* 0x68 */ public float AnimationScale;
        /* 0x6C */ public float BackwardScatteringG;
        /* 0x70 */ public float BaseScale;
        /* 0x74 */ public float CloudBottomFade;
        /* 0x78 */ public float CloudDistortion;
        /* 0x7C */ public float CloudDistortionScale;
        /* 0x80 */ public float ConeRadius;
        /* 0x84 */ public float DarkOutlineScalar;
        /* 0x88 */ public float Density;
        /* 0x8C */ public float DetailScale;
        /* 0x90 */ public float ErosionEdgeSize;
        /* 0x94 */ public float ForwardScatteringG;
        /* 0x98 */ public float HorizonCoverageEnd;
        /* 0x9C */ public float HorizonCoverageStart;
        /* 0xA0 */ public float HorizonDistance;
        /* 0xA4 */ public float HorizonFadeScalar;
        /* 0xA8 */ public float HorizonFadeStartAlpha;
        /* 0xAC */ public float LightScalar;
        /* 0xB0 */ public float LODDistance;
        /* 0xB4 */ public float MaxIterations;
        /* 0xB8 */ public float RayMinimumY;
        /* 0xBC */ public float SampleScalar;
        /* 0xC0 */ public float SampleThreshold;
        /* 0xC4 */ public float SunRayLength;
    }
}
