using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x86066780075E1F18, NameHash = 0xE39CB7AA4D818260)]
    public class TkMaterialMetaData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 ExternalMaterial;
        // size: 0x7
        public enum ShaderEnum { UberShader, Sky, Screen, UberHack, UIScreen, ShaderMillParticle, ShaderMillUber
        }
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
        /* 0x09B */ public bool SubsurfaceMask;
        /* 0x09C */ public NMSString0x20 MaterialClass;
        /* 0x0BC */ public NMSString0x80 ForceDiffuse;
        /* 0x13C */ public NMSString0x80 ForceNormal;
        /* 0x1BC */ public NMSString0x80 ForceMask;
        /* 0x23C */ public NMSString0x80 ForceFeature;
        /* 0x2BC */ public NMSString0x80 DetailDiffuse;
        /* 0x33C */ public NMSString0x80 DetailNormal;
        /* 0x3BC */ public float DetailTiling;
        /* 0x3C0 */ public float MultiplyDetailTiling;
        /* 0x3C4 */ public int DetailImages;
        /* 0x3C8 */ public int MultiplyDetailImages;
        /* 0x3CC */ public bool AOMap;
        /* 0x3CD */ public bool MultiplySecondUVSet;
        /* 0x3CE */ public bool VertexDetailBlend;
        /* 0x3D0 */ public float DetailHeightBlend;
        /* 0x3D4 */ public float NormalTiling;
        /* 0x3D8 */ public bool SpaceObject;
        /* 0x3DC */ public float Glow;
        /* 0x3E0 */ public bool GlowMask;
        /* 0x3E1 */ public bool BrightEdge;
        /* 0x3E2 */ public bool CameraRelative;
        /* 0x3E3 */ public bool Colourisable;
        /* 0x3E4 */ public bool ColourMask;
        /* 0x3E5 */ public bool Multitexture;
        /* 0x3E6 */ public bool FeatureMap;
        /* 0x3E7 */ public bool AlphaCutout;
        /* 0x3E8 */ public bool DetailedAlphaCutout;
        /* 0x3E9 */ public bool Wind;
        /* 0x3EA */ public bool EnvironmentalOverlay;
        /* 0x3EB */ public bool MatchGroundColour;
        /* 0x3EC */ public float TerrainNormalFactor;
        /* 0x3F0 */ public float SoftFadeStrength;
        /* 0x3F4 */ public bool ScreenSpaceFade;
        /* 0x3F5 */ public bool AcuteAngleFadeOut;
        /* 0x3F6 */ public bool ClampAmbientLight;
        /* 0x3F7 */ public bool DoubleSided;
        /* 0x3F8 */ public bool DecalDiffuse;
        /* 0x3F9 */ public bool DecalTerrainOnly;
        // size: 0x3
        public enum DecalNormalEnum { None, Decal, Vertex }
        /* 0x3FC */ public DecalNormalEnum DecalNormal;
        /* 0x400 */ public bool Billboard;
        /* 0x401 */ public bool RotateAroundAt;
        /* 0x402 */ public bool MergedMeshBillboard;
        /* 0x404 */ public float BillboardSphereFactor;
        /* 0x408 */ public bool Imposter;
        /* 0x409 */ public bool ScanEffect;
        /* 0x40A */ public bool WriteLogZ;
        /* 0x40B */ public bool DisableAmbient;
        /* 0x40C */ public bool DisablePostProcess;
        /* 0x40D */ public bool WarpedDiffuseLighting;
        /* 0x40E */ public bool AnisotropicFilter;
        /* 0x410 */ public float TessellationHeight;
        /* 0x414 */ public bool Dissolve;
        /* 0x415 */ public bool InvertAlpha;
        /* 0x416 */ public bool BeforeUI;
        /* 0x417 */ public bool DepthMaskUI;
        /* 0x418 */ public bool AlwaysOnTopUI;
        /* 0x419 */ public bool ScreenSpaceReflections;
        /* 0x41A */ public bool ReflectionProbe;
        /* 0x41B */ public bool DrawToBloom;
        /* 0x41C */ public bool DrawToLensFlare;
        /* 0x41D */ public bool DoubleBufferGeometry;
        /* 0x41E */ public bool CreateFur;
        /* 0x420 */ public float ShellsHeight;
        /* 0x424 */ public float FurNoiseScale;
        /* 0x428 */ public float FurNoiseThickness;
        /* 0x42C */ public float FurNoiseTurbulence;
        /* 0x430 */ public float FurTurbulenceScale;
        /* 0x434 */ public bool StretchyParticle;
        /* 0x435 */ public bool UVScrolling;
        /* 0x438 */ public float UVScrollX;
        /* 0x43C */ public float UVScrollY;
        /* 0x440 */ public float UVScrollNormalX;
        /* 0x444 */ public float UVScrollNormalY;
        /* 0x448 */ public float UVFrameTime;
        /* 0x44C */ public bool UVAnimation;
        /* 0x44D */ public bool UVTileAlts;
        /* 0x450 */ public float UVNumTilesX;
        /* 0x454 */ public float UVNumTilesY;
        /* 0x458 */ public float Refraction;
        /* 0x45C */ public float RefractionIndex;
        /* 0x460 */ public bool RefractionMask;
        /* 0x464 */ public float ParticleRefractionStrengthX;
        /* 0x468 */ public float ParticleRefractionStrengthY;
        /* 0x46C */ public float ParticleRefractionBrightnessMultiplier;
        /* 0x470 */ public float ParticleRefractionTint;
        /* 0x474 */ public bool ParallaxMapped;
        /* 0x478 */ public float ParallaxDepth;
        /* 0x47C */ public int NumSteps;
        /* 0x480 */ public bool SelfShadow;
        /* 0x484 */ public float ShadowFactor;
        /* 0x488 */ public bool DisplacementWave;
        /* 0x489 */ public bool DisplacementPositionOffset;
        /* 0x48C */ public float WaveOneSpeed;
        /* 0x490 */ public Vector3f WaveOneAmplitude;
        /* 0x4A0 */ public Vector3f WaveOneFrequency;
        /* 0x4B0 */ public Vector3f WaveOneFallOff;
        /* 0x4C0 */ public float WaveTwoSpeed;
        /* 0x4D0 */ public Vector3f WaveTwoAmplitude;
        /* 0x4E0 */ public Vector3f WaveTwoFrequency;
        /* 0x4F0 */ public Vector3f WaveTwoFallOff;
        /* 0x500 */ public TkMaterialShaderMillData ShaderMillData;
    }
}
