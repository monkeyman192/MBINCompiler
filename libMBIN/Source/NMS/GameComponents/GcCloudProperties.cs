using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xF0, GUID = 0x61834312DCADA196, NameHash = 0x21C58A0DDEF4EC87)]
    public class GcCloudProperties : NMSTemplate
    {
        /* 0x00 */ public Vector2f CoverageOffset;
        /* 0x08 */ public float HorizonCoverageStart;
        /* 0x0C */ public float HorizonCoverageEnd;
        /* 0x10 */ public Colour CloudBaseColour;
        /* 0x20 */ public Colour CloudTopColour;
        /* 0x30 */ public float LightScalar;
        /* 0x34 */ public float AmbientScalar;
        /* 0x38 */ public float SunRayLength;
        /* 0x3C */ public float ConeRadius;
        /* 0x40 */ public float Density;
        /* 0x44 */ public float AmbientDensity;
        /* 0x48 */ public float ForwardScatteringG;
        /* 0x4C */ public float BackwardScatteringG;
        /* 0x50 */ public float DarkOutlineScalar;
        /* 0x54 */ public float AnimationScale;
        /* 0x58 */ public Vector2f WindOffset;
        /* 0x60 */ public Vector2f StratosphereWindOffset;
        /* 0x68 */ public float BaseScale;
        /* 0x6C */ public float SampleScalar;
        /* 0x70 */ public float SampleThreshold;
        /* 0x74 */ public float CloudBottomFade;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x78 */ public byte[] Padding78;
        /* 0x80 */ public Vector4f CloudHeightGradient1;
        /* 0x90 */ public Vector4f CloudHeightGradient2;
        /* 0xA0 */ public Vector4f CloudHeightGradient3;
        /* 0xB0 */ public float DetailScale;
        /* 0xB4 */ public float ErosionEdgeSize;
        /* 0xB8 */ public float CloudDistortion;
        /* 0xBC */ public float CloudDistortionScale;
        /* 0xC0 */ public float MaxIterations;
        /* 0xC4 */ public float RayMinimumY;
        /* 0xC8 */ public float LODDistance;
        /* 0xCC */ public float HorizonFadeStartAlpha;
        /* 0xD0 */ public float HorizonFadeScalar;
        /* 0xD4 */ public float HorizonDistance;
        /* 0xD8 */ public float AtmosphereStartHeight;
        /* 0xDC */ public float AtmosphereEndHeight;
        /* 0xE0 */ public float StratosphereHeight;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0xE4 */ public byte[] EndPadding;
    }
}
