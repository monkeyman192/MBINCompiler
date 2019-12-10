using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x440, Alignment = 0x10, GUID = 0x5D3A372D8396458E, NameHash = 0xE39CB7AA4D818260)]
    public class TkMaterialMetaData : NMSTemplate {

        [NMS(Size = 0x80)]
        /* 0x000 */ public string ExternalMaterial;
		public enum ShaderEnum { UberShader, Sky, Screen, UberHack, UIScreen }
		/* 0x080 */ public ShaderEnum Shader;
        /* 0x084 */ public bool Transparent;
        /* 0x088 */ public int TransparencyLayerID;
        /* 0x08C */ public bool Additive;
        /* 0x08D */ public bool VertexColour;
        /* 0x08E */ public bool DisableZTest;
        /* 0x08F */ public bool Unlit;
        /* 0x090 */ public bool ReceiveShadow;
        /* 0x091 */ public bool CastShadow;
        /* 0x092 */ public bool ShadowOnly;
        /* 0x093 */ public bool UISurface;
        /* 0x094 */ public float Roughness;
        /* 0x098 */ public bool RoughnessMask;
        /* 0x099 */ public bool Metallic;
        /* 0x09A */ public bool MetallicMask;
        /* 0x09B */ public bool SubSurfaceMask;
        /* 0x09C */ public bool ParallaxMapped;
        /* 0x09D */ public bool RefractionMap;
        [NMS(Size = 0x80)]
        /* 0x09E */ public string ForceDiffuse;
        [NMS(Size = 0x80)]
        /* 0x11E */ public string ForceNormal;
        [NMS(Size = 0x80)]
        /* 0x19E */ public string ForceMask;
        [NMS(Size = 0x80)]
        /* 0x21E */ public string DetailDiffuse;
        [NMS(Size = 0x80)]
        /* 0x29E */ public string DetailNormal;
        /* 0x320 */ public float DetailTiling;
        /* 0x324 */ public float MultiplyDetailTiling;
        /* 0x328 */ public int DetailImages;
        /* 0x32C */ public int MultiplyDetailImages;
        /* 0x330 */ public bool A0Map;
        /* 0x331 */ public bool MultiplySecondUVSet;
        /* 0x334 */ public float NormalTiling;
        /* 0x338 */ public bool SpaceObject;
        /* 0x33C */ public float Glow;
        /* 0x340 */ public bool GlowMask;
        /* 0x341 */ public bool CameraRelative;
        /* 0x342 */ public bool Colourisable;
        /* 0x343 */ public bool ColourMask;
        /* 0x344 */ public bool MultiTexture;
        /* 0x345 */ public bool AlphaCutout;
        /* 0x346 */ public bool DetailedAlphaCutout;
        /* 0x347 */ public bool Wind;
        /* 0x348 */ public bool DetailOverlay;
        /* 0x349 */ public bool MatchGroundColour;
        /* 0x34C */ public float TerrainNormalFactor;
        /* 0x350 */ public bool ScreenSpaceFade;
        /* 0x351 */ public bool AcuteAngleFadeOut;
        /* 0x352 */ public bool ClampAmbientLight;
        /* 0x353 */ public bool DoubleSided;
        /* 0x354 */ public bool DecalDiffuse;
		public enum DecalNormalEnum { None, Decal, Vertex }
		/* 0x358 */ public DecalNormalEnum DecalNormal;
        /* 0x35C */ public bool Billboard;
        /* 0x35D */ public bool RotateAroundAt;
        /* 0x35E */ public bool MergedMeshBillboard;
        /* 0x360 */ public float BillboardSphereFactor;
        /* 0x364 */ public bool Imposter;

        /* 0x365 */ public bool ScanEffect;
        /* 0x366 */ public bool WriteLogZ;
        /* 0x367 */ public bool DisableAmbient;
        /* 0x368 */ public bool DisablePostProcess;
        /* 0x369 */ public bool WarpedDiffuseLighting;
        [NMS(Size = 0x20)]
        /* 0x36A */ public string MaterialClass;
        /* 0x38A */ public bool AnisotropicFilter;
        /* 0x38C */ public float TessellationHeight;
        /* 0x390 */ public float ShellsHeight;
        /* 0x394 */ public bool Dissolve;
        /* 0x395 */ public bool InvertAlpha;
        /* 0x396 */ public bool BeforeUI;
        /* 0x397 */ public bool DepthMaskUI;
        /* 0x398 */ public bool AlwaysOnTopUI;
        /* 0x399 */ public bool StretchyParticle;
        /* 0x39A */ public bool UVScrolling;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x39B */ public byte[] Padding39B;
        /* 0x39C */ public float UVScrollX;
        /* 0x3A0 */ public float UVScrollY;
        /* 0x3A4 */ public float UVScrollNormalX;
        /* 0x3A8 */ public float UVScrollNormalY;
        /* 0x3AC */ public float UVFrameTime;
        /* 0x3B0 */ public bool UVAnimation;
        /* 0x3B1 */ public bool UVTileAlts;
        /* 0x3B4 */ public float UVNumTilesX;
        /* 0x3B8 */ public float UVNumTilesY;
        /* 0x3BC */ public bool DisplacementWave;
        /* 0x3C0 */ public float WaveOneSpeed;
        /* 0x3D0 */ public Vector3f WaveOneAmplitude;
        /* 0x3E0 */ public Vector3f WaveOneFrequency;
        /* 0x3F0 */ public Vector3f WaveOneFallOff;
        /* 0x400 */ public float WaveTwoSpeed;
        /* 0x410 */ public Vector3f WaveTwoAmplitude;
        /* 0x420 */ public Vector3f WaveTwoFrequency;
        /* 0x430 */ public Vector3f WaveTwoFallOff;

    }

}
