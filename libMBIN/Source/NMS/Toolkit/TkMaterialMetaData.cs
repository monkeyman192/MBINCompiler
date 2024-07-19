using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB12364AE33CD8071, NameHash = 0xB36368E9)]
    public class TkMaterialMetaData : NMSTemplate
    {
        [NMS(Index = 123)]
        /* 0x000 */ public Vector3f WaveOneAmplitude;
        [NMS(Index = 125)]
        /* 0x010 */ public Vector3f WaveOneFallOff;
        [NMS(Index = 124)]
        /* 0x020 */ public Vector3f WaveOneFrequency;
        [NMS(Index = 127)]
        /* 0x030 */ public Vector3f WaveTwoAmplitude;
        [NMS(Index = 129)]
        /* 0x040 */ public Vector3f WaveTwoFallOff;
        [NMS(Index = 128)]
        /* 0x050 */ public Vector3f WaveTwoFrequency;
        [NMS(Index = 130)]
        /* 0x060 */ public TkMaterialShaderMillData ShaderMillData;
        [NMS(Index = 26)]
        /* 0x378 */ public VariableSizeString DetailDiffuse;
        [NMS(Index = 27)]
        /* 0x388 */ public VariableSizeString DetailNormal;
        [NMS(Index = 0)]
        /* 0x398 */ public VariableSizeString ExternalMaterial;
        [NMS(Index = 22)]
        /* 0x3A8 */ public VariableSizeString ForceDiffuse;
        [NMS(Index = 25)]
        /* 0x3B8 */ public VariableSizeString ForceFeature;
        [NMS(Index = 24)]
        /* 0x3C8 */ public VariableSizeString ForceMask;
        [NMS(Index = 23)]
        /* 0x3D8 */ public VariableSizeString ForceNormal;
        [NMS(Index = 70)]
        /* 0x3E8 */ public float BillboardSphereFactor;
        [NMS(Index = 51)]
        /* 0x3EC */ public float BranchAroundTrunkAnim;
        [NMS(Index = 50)]
        /* 0x3F0 */ public float BranchHorizontalSwing;
        [NMS(Index = 49)]
        /* 0x3F4 */ public float BranchVerticalSwing;
        // size: 0x3
        public enum DecalNormalEnum : uint {
            None,
            Decal,
            Vertex,
        }
        [NMS(Index = 66)]
        /* 0x3F8 */ public DecalNormalEnum DecalNormal;
        [NMS(Index = 34)]
        /* 0x3FC */ public float DetailHeightBlend;
        [NMS(Index = 35)]
        /* 0x400 */ public float DetailHeightBoost;
        [NMS(Index = 30)]
        /* 0x404 */ public int DetailImages;
        [NMS(Index = 28)]
        /* 0x408 */ public float DetailTiling;
        [NMS(Index = 93)]
        /* 0x40C */ public float FurNoiseScale;
        [NMS(Index = 94)]
        /* 0x410 */ public float FurNoiseThickness;
        [NMS(Index = 95)]
        /* 0x414 */ public float FurNoiseTurbulence;
        [NMS(Index = 96)]
        /* 0x418 */ public float FurTurbulenceScale;
        [NMS(Index = 38)]
        /* 0x41C */ public float Glow;
        [NMS(Index = 52)]
        /* 0x420 */ public float HeightScale;
        [NMS(Index = 16)]
        /* 0x424 */ public float IBLWeight;
        [NMS(Index = 54)]
        /* 0x428 */ public float LeafNoise;
        [NMS(Index = 55)]
        /* 0x42C */ public float LeafSwing;
        [NMS(Index = 31)]
        /* 0x430 */ public int MultiplyDetailImages;
        [NMS(Index = 29)]
        /* 0x434 */ public float MultiplyDetailTiling;
        [NMS(Index = 36)]
        /* 0x438 */ public float NormalTiling;
        [NMS(Index = 117)]
        /* 0x43C */ public int NumSteps;
        [NMS(Index = 116)]
        /* 0x440 */ public float ParallaxDepth;
        [NMS(Index = 113)]
        /* 0x444 */ public float ParticleRefractionBrightnessMultiplier;
        [NMS(Index = 111)]
        /* 0x448 */ public float ParticleRefractionStrengthX;
        [NMS(Index = 112)]
        /* 0x44C */ public float ParticleRefractionStrengthY;
        [NMS(Index = 114)]
        /* 0x450 */ public float ParticleRefractionTint;
        [NMS(Index = 89)]
        /* 0x454 */ public float ReactivityBias;
        [NMS(Index = 108)]
        /* 0x458 */ public float Refraction;
        [NMS(Index = 109)]
        /* 0x45C */ public float RefractionIndex;
        [NMS(Index = 13)]
        /* 0x460 */ public float Roughness;
        // size: 0x7
        public enum ShaderEnum : uint {
            UberShader,
            Sky,
            Screen,
            UberHack,
            UIScreen,
            ShaderMillParticle,
            ShaderMillUber,
        }
        [NMS(Index = 1)]
        /* 0x464 */ public ShaderEnum Shader;
        [NMS(Index = 119)]
        /* 0x468 */ public float ShadowFactor;
        [NMS(Index = 92)]
        /* 0x46C */ public float ShellsHeight;
        [NMS(Index = 59)]
        /* 0x470 */ public float SoftFadeStrength;
        [NMS(Index = 20)]
        /* 0x474 */ public float SubsurfaceWeight;
        [NMS(Index = 58)]
        /* 0x478 */ public float TerrainNormalFactor;
        [NMS(Index = 78)]
        /* 0x47C */ public float TessellationHeight;
        [NMS(Index = 3)]
        /* 0x480 */ public int TransparencyLayerID;
        [NMS(Index = 53)]
        /* 0x484 */ public float TrunkBend;
        [NMS(Index = 103)]
        /* 0x488 */ public float UVFrameTime;
        [NMS(Index = 106)]
        /* 0x48C */ public float UVNumTilesX;
        [NMS(Index = 107)]
        /* 0x490 */ public float UVNumTilesY;
        [NMS(Index = 101)]
        /* 0x494 */ public float UVScrollNormalX;
        [NMS(Index = 102)]
        /* 0x498 */ public float UVScrollNormalY;
        [NMS(Index = 99)]
        /* 0x49C */ public float UVScrollX;
        [NMS(Index = 100)]
        /* 0x4A0 */ public float UVScrollY;
        [NMS(Index = 122)]
        /* 0x4A4 */ public float WaveOneSpeed;
        [NMS(Index = 126)]
        /* 0x4A8 */ public float WaveTwoSpeed;
        [NMS(Index = 21)]
        /* 0x4AC */ public NMSString0x20 MaterialClass;
        [NMS(Index = 60)]
        /* 0x4CC */ public bool AcuteAngleFadeOut;
        [NMS(Index = 4)]
        /* 0x4CD */ public bool Additive;
        [NMS(Index = 46)]
        /* 0x4CE */ public bool AlphaCutout;
        [NMS(Index = 83)]
        /* 0x4CF */ public bool AlwaysOnTopUI;
        [NMS(Index = 77)]
        /* 0x4D0 */ public bool AnisotropicFilter;
        [NMS(Index = 32)]
        /* 0x4D1 */ public bool AOMap;
        [NMS(Index = 81)]
        /* 0x4D2 */ public bool BeforeUI;
        [NMS(Index = 67)]
        /* 0x4D3 */ public bool Billboard;
        [NMS(Index = 40)]
        /* 0x4D4 */ public bool BrightEdge;
        [NMS(Index = 41)]
        /* 0x4D5 */ public bool CameraRelative;
        [NMS(Index = 10)]
        /* 0x4D6 */ public bool CastShadow;
        [NMS(Index = 61)]
        /* 0x4D7 */ public bool ClampAmbientLight;
        [NMS(Index = 42)]
        /* 0x4D8 */ public bool Colourisable;
        [NMS(Index = 43)]
        /* 0x4D9 */ public bool ColourMask;
        [NMS(Index = 91)]
        /* 0x4DA */ public bool CreateFur;
        [NMS(Index = 64)]
        /* 0x4DB */ public bool DecalDiffuse;
        [NMS(Index = 65)]
        /* 0x4DC */ public bool DecalTerrainOnly;
        [NMS(Index = 82)]
        /* 0x4DD */ public bool DepthMaskUI;
        [NMS(Index = 47)]
        /* 0x4DE */ public bool DetailedAlphaCutout;
        [NMS(Index = 74)]
        /* 0x4DF */ public bool DisableAmbient;
        [NMS(Index = 75)]
        /* 0x4E0 */ public bool DisablePostProcess;
        [NMS(Index = 6)]
        /* 0x4E1 */ public bool DisableZTest;
        [NMS(Index = 121)]
        /* 0x4E2 */ public bool DisplacementPositionOffset;
        [NMS(Index = 120)]
        /* 0x4E3 */ public bool DisplacementWave;
        [NMS(Index = 79)]
        /* 0x4E4 */ public bool Dissolve;
        [NMS(Index = 88)]
        /* 0x4E5 */ public bool DoubleBufferGeometry;
        [NMS(Index = 62)]
        /* 0x4E6 */ public bool DoubleSided;
        [NMS(Index = 63)]
        /* 0x4E7 */ public bool DoubleSidedKeepNormals;
        [NMS(Index = 86)]
        /* 0x4E8 */ public bool DrawToBloom;
        [NMS(Index = 87)]
        /* 0x4E9 */ public bool DrawToLensFlare;
        [NMS(Index = 56)]
        /* 0x4EA */ public bool EnvironmentalOverlay;
        [NMS(Index = 45)]
        /* 0x4EB */ public bool FeatureMap;
        [NMS(Index = 7)]
        /* 0x4EC */ public bool FullPrecisionPosition;
        [NMS(Index = 39)]
        /* 0x4ED */ public bool GlowMask;
        [NMS(Index = 97)]
        /* 0x4EE */ public bool HighQualityParticle;
        [NMS(Index = 15)]
        /* 0x4EF */ public bool ImageBasedLighting;
        [NMS(Index = 71)]
        /* 0x4F0 */ public bool Imposter;
        [NMS(Index = 80)]
        /* 0x4F1 */ public bool InvertAlpha;
        [NMS(Index = 57)]
        /* 0x4F2 */ public bool MatchGroundColour;
        [NMS(Index = 69)]
        /* 0x4F3 */ public bool MergedMeshBillboard;
        [NMS(Index = 17)]
        /* 0x4F4 */ public bool Metallic;
        [NMS(Index = 18)]
        /* 0x4F5 */ public bool MetallicMask;
        [NMS(Index = 44)]
        /* 0x4F6 */ public bool Multitexture;
        [NMS(Index = 115)]
        /* 0x4F7 */ public bool ParallaxMapped;
        [NMS(Index = 9)]
        /* 0x4F8 */ public bool ReceiveShadow;
        [NMS(Index = 85)]
        /* 0x4F9 */ public bool ReflectionProbe;
        [NMS(Index = 110)]
        /* 0x4FA */ public bool RefractionMask;
        [NMS(Index = 68)]
        /* 0x4FB */ public bool RotateAroundAt;
        [NMS(Index = 14)]
        /* 0x4FC */ public bool RoughnessMask;
        [NMS(Index = 72)]
        /* 0x4FD */ public bool ScanEffect;
        [NMS(Index = 84)]
        /* 0x4FE */ public bool ScreenSpaceReflections;
        [NMS(Index = 118)]
        /* 0x4FF */ public bool SelfShadow;
        [NMS(Index = 11)]
        /* 0x500 */ public bool ShadowOnly;
        [NMS(Index = 90)]
        /* 0x501 */ public bool SimulatedCloth;
        [NMS(Index = 37)]
        /* 0x502 */ public bool SpaceObject;
        [NMS(Index = 19)]
        /* 0x503 */ public bool SubsurfaceMask;
        [NMS(Index = 2)]
        /* 0x504 */ public bool Transparent;
        [NMS(Index = 12)]
        /* 0x505 */ public bool UISurface;
        [NMS(Index = 8)]
        /* 0x506 */ public bool Unlit;
        [NMS(Index = 104)]
        /* 0x507 */ public bool UVAnimation;
        [NMS(Index = 98)]
        /* 0x508 */ public bool UVScrolling;
        [NMS(Index = 105)]
        /* 0x509 */ public bool UVTileAlts;
        [NMS(Index = 5)]
        /* 0x50A */ public bool VertexColour;
        [NMS(Index = 33)]
        /* 0x50B */ public bool VertexDetailBlend;
        [NMS(Index = 76)]
        /* 0x50C */ public bool WarpedDiffuseLighting;
        [NMS(Index = 48)]
        /* 0x50D */ public bool Wind;
        [NMS(Index = 73)]
        /* 0x50E */ public bool WriteLogZ;
    }
}
