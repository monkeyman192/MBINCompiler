namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x112D5C8D7E3D0B38, NameHash = 0x21C58A0DDEF4EC87)]
    public class GcCloudProperties : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Colour CloudBaseColour;
        [NMS(Index = 20)]
        /* 0x10 */ public Vector4f CloudHeightGradient1;
        [NMS(Index = 21)]
        /* 0x20 */ public Vector4f CloudHeightGradient2;
        [NMS(Index = 22)]
        /* 0x30 */ public Vector4f CloudHeightGradient3;
        [NMS(Index = 3)]
        /* 0x40 */ public Colour CloudTopColour;
        [NMS(Index = 15)]
        /* 0x50 */ public Vector2f StratosphereWindOffset;
        [NMS(Index = 14)]
        /* 0x58 */ public Vector2f WindOffset;
        [NMS(Index = 9)]
        /* 0x60 */ public float AmbientDensity;
        [NMS(Index = 5)]
        /* 0x64 */ public float AmbientScalar;
        [NMS(Index = 13)]
        /* 0x68 */ public float AnimationScale;
        [NMS(Index = 11)]
        /* 0x6C */ public float BackwardScatteringG;
        [NMS(Index = 16)]
        /* 0x70 */ public float BaseScale;
        [NMS(Index = 19)]
        /* 0x74 */ public float CloudBottomFade;
        [NMS(Index = 25)]
        /* 0x78 */ public float CloudDistortion;
        [NMS(Index = 26)]
        /* 0x7C */ public float CloudDistortionScale;
        [NMS(Index = 7)]
        /* 0x80 */ public float ConeRadius;
        [NMS(Index = 12)]
        /* 0x84 */ public float DarkOutlineScalar;
        [NMS(Index = 8)]
        /* 0x88 */ public float Density;
        [NMS(Index = 23)]
        /* 0x8C */ public float DetailScale;
        [NMS(Index = 24)]
        /* 0x90 */ public float ErosionEdgeSize;
        [NMS(Index = 10)]
        /* 0x94 */ public float ForwardScatteringG;
        [NMS(Index = 1)]
        /* 0x98 */ public float HorizonCoverageEnd;
        [NMS(Index = 0)]
        /* 0x9C */ public float HorizonCoverageStart;
        [NMS(Index = 32)]
        /* 0xA0 */ public float HorizonDistance;
        [NMS(Index = 31)]
        /* 0xA4 */ public float HorizonFadeScalar;
        [NMS(Index = 30)]
        /* 0xA8 */ public float HorizonFadeStartAlpha;
        [NMS(Index = 4)]
        /* 0xAC */ public float LightScalar;
        [NMS(Index = 29)]
        /* 0xB0 */ public float LODDistance;
        [NMS(Index = 27)]
        /* 0xB4 */ public float MaxIterations;
        [NMS(Index = 28)]
        /* 0xB8 */ public float RayMinimumY;
        [NMS(Index = 17)]
        /* 0xBC */ public float SampleScalar;
        [NMS(Index = 18)]
        /* 0xC0 */ public float SampleThreshold;
        [NMS(Index = 6)]
        /* 0xC4 */ public float SunRayLength;
    }
}
