using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x83268F02FC4A5E72, NameHash = 0xE39CB7AA4D818260)]
    public class TkMaterialMetaData : NMSTemplate
    {
        [NMS(Index = 114)]
        /* 0x000 */ public Vector3f WaveOneAmplitude;
        [NMS(Index = 116)]
        /* 0x010 */ public Vector3f WaveOneFallOff;
        [NMS(Index = 115)]
        /* 0x020 */ public Vector3f WaveOneFrequency;
        [NMS(Index = 118)]
        /* 0x030 */ public Vector3f WaveTwoAmplitude;
        [NMS(Index = 120)]
        /* 0x040 */ public Vector3f WaveTwoFallOff;
        [NMS(Index = 119)]
        /* 0x050 */ public Vector3f WaveTwoFrequency;
        [NMS(Index = 121)]
        /* 0x060 */ public TkMaterialShaderMillData ShaderMillData;
        [NMS(Index = 61)]
        /* 0x378 */ public float BillboardSphereFactor;
        // size: 0x3
        public enum DecalNormalEnum : uint {
            None,
            Decal,
            Vertex,
        }
        [NMS(Index = 57)]
        /* 0x37C */ public DecalNormalEnum DecalNormal;
        [NMS(Index = 34)]
        /* 0x380 */ public float DetailHeightBlend;
        [NMS(Index = 29)]
        /* 0x384 */ public int DetailImages;
        [NMS(Index = 27)]
        /* 0x388 */ public float DetailTiling;
        [NMS(Index = 84)]
        /* 0x38C */ public float FurNoiseScale;
        [NMS(Index = 85)]
        /* 0x390 */ public float FurNoiseThickness;
        [NMS(Index = 86)]
        /* 0x394 */ public float FurNoiseTurbulence;
        [NMS(Index = 87)]
        /* 0x398 */ public float FurTurbulenceScale;
        [NMS(Index = 37)]
        /* 0x39C */ public float Glow;
        [NMS(Index = 15)]
        /* 0x3A0 */ public float IBLWeight;
        [NMS(Index = 30)]
        /* 0x3A4 */ public int MultiplyDetailImages;
        [NMS(Index = 28)]
        /* 0x3A8 */ public float MultiplyDetailTiling;
        [NMS(Index = 35)]
        /* 0x3AC */ public float NormalTiling;
        [NMS(Index = 108)]
        /* 0x3B0 */ public int NumSteps;
        [NMS(Index = 107)]
        /* 0x3B4 */ public float ParallaxDepth;
        [NMS(Index = 104)]
        /* 0x3B8 */ public float ParticleRefractionBrightnessMultiplier;
        [NMS(Index = 102)]
        /* 0x3BC */ public float ParticleRefractionStrengthX;
        [NMS(Index = 103)]
        /* 0x3C0 */ public float ParticleRefractionStrengthY;
        [NMS(Index = 105)]
        /* 0x3C4 */ public float ParticleRefractionTint;
        [NMS(Index = 80)]
        /* 0x3C8 */ public float ReactivityBias;
        [NMS(Index = 99)]
        /* 0x3CC */ public float Refraction;
        [NMS(Index = 100)]
        /* 0x3D0 */ public float RefractionIndex;
        [NMS(Index = 12)]
        /* 0x3D4 */ public float Roughness;
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
        /* 0x3D8 */ public ShaderEnum Shader;
        [NMS(Index = 110)]
        /* 0x3DC */ public float ShadowFactor;
        [NMS(Index = 83)]
        /* 0x3E0 */ public float ShellsHeight;
        [NMS(Index = 51)]
        /* 0x3E4 */ public float SoftFadeStrength;
        [NMS(Index = 19)]
        /* 0x3E8 */ public float SubsurfaceWeight;
        [NMS(Index = 50)]
        /* 0x3EC */ public float TerrainNormalFactor;
        [NMS(Index = 69)]
        /* 0x3F0 */ public float TessellationHeight;
        [NMS(Index = 3)]
        /* 0x3F4 */ public int TransparencyLayerID;
        [NMS(Index = 94)]
        /* 0x3F8 */ public float UVFrameTime;
        [NMS(Index = 97)]
        /* 0x3FC */ public float UVNumTilesX;
        [NMS(Index = 98)]
        /* 0x400 */ public float UVNumTilesY;
        [NMS(Index = 92)]
        /* 0x404 */ public float UVScrollNormalX;
        [NMS(Index = 93)]
        /* 0x408 */ public float UVScrollNormalY;
        [NMS(Index = 90)]
        /* 0x40C */ public float UVScrollX;
        [NMS(Index = 91)]
        /* 0x410 */ public float UVScrollY;
        [NMS(Index = 113)]
        /* 0x414 */ public float WaveOneSpeed;
        [NMS(Index = 117)]
        /* 0x418 */ public float WaveTwoSpeed;
        [NMS(Index = 25)]
        /* 0x41C */ public NMSString0x80 DetailDiffuse;
        [NMS(Index = 26)]
        /* 0x49C */ public NMSString0x80 DetailNormal;
        [NMS(Index = 0)]
        /* 0x51C */ public NMSString0x80 ExternalMaterial;
        [NMS(Index = 21)]
        /* 0x59C */ public NMSString0x80 ForceDiffuse;
        [NMS(Index = 24)]
        /* 0x61C */ public NMSString0x80 ForceFeature;
        [NMS(Index = 23)]
        /* 0x69C */ public NMSString0x80 ForceMask;
        [NMS(Index = 22)]
        /* 0x71C */ public NMSString0x80 ForceNormal;
        [NMS(Index = 20)]
        /* 0x79C */ public NMSString0x20 MaterialClass;
        [NMS(Index = 52)]
        /* 0x7BC */ public bool AcuteAngleFadeOut;
        [NMS(Index = 4)]
        /* 0x7BD */ public bool Additive;
        [NMS(Index = 45)]
        /* 0x7BE */ public bool AlphaCutout;
        [NMS(Index = 74)]
        /* 0x7BF */ public bool AlwaysOnTopUI;
        [NMS(Index = 68)]
        /* 0x7C0 */ public bool AnisotropicFilter;
        [NMS(Index = 31)]
        /* 0x7C1 */ public bool AOMap;
        [NMS(Index = 72)]
        /* 0x7C2 */ public bool BeforeUI;
        [NMS(Index = 58)]
        /* 0x7C3 */ public bool Billboard;
        [NMS(Index = 39)]
        /* 0x7C4 */ public bool BrightEdge;
        [NMS(Index = 40)]
        /* 0x7C5 */ public bool CameraRelative;
        [NMS(Index = 9)]
        /* 0x7C6 */ public bool CastShadow;
        [NMS(Index = 53)]
        /* 0x7C7 */ public bool ClampAmbientLight;
        [NMS(Index = 41)]
        /* 0x7C8 */ public bool Colourisable;
        [NMS(Index = 42)]
        /* 0x7C9 */ public bool ColourMask;
        [NMS(Index = 82)]
        /* 0x7CA */ public bool CreateFur;
        [NMS(Index = 55)]
        /* 0x7CB */ public bool DecalDiffuse;
        [NMS(Index = 56)]
        /* 0x7CC */ public bool DecalTerrainOnly;
        [NMS(Index = 73)]
        /* 0x7CD */ public bool DepthMaskUI;
        [NMS(Index = 46)]
        /* 0x7CE */ public bool DetailedAlphaCutout;
        [NMS(Index = 65)]
        /* 0x7CF */ public bool DisableAmbient;
        [NMS(Index = 66)]
        /* 0x7D0 */ public bool DisablePostProcess;
        [NMS(Index = 6)]
        /* 0x7D1 */ public bool DisableZTest;
        [NMS(Index = 112)]
        /* 0x7D2 */ public bool DisplacementPositionOffset;
        [NMS(Index = 111)]
        /* 0x7D3 */ public bool DisplacementWave;
        [NMS(Index = 70)]
        /* 0x7D4 */ public bool Dissolve;
        [NMS(Index = 79)]
        /* 0x7D5 */ public bool DoubleBufferGeometry;
        [NMS(Index = 54)]
        /* 0x7D6 */ public bool DoubleSided;
        [NMS(Index = 77)]
        /* 0x7D7 */ public bool DrawToBloom;
        [NMS(Index = 78)]
        /* 0x7D8 */ public bool DrawToLensFlare;
        [NMS(Index = 48)]
        /* 0x7D9 */ public bool EnvironmentalOverlay;
        [NMS(Index = 44)]
        /* 0x7DA */ public bool FeatureMap;
        [NMS(Index = 38)]
        /* 0x7DB */ public bool GlowMask;
        [NMS(Index = 88)]
        /* 0x7DC */ public bool HighQualityParticle;
        [NMS(Index = 14)]
        /* 0x7DD */ public bool ImageBasedLighting;
        [NMS(Index = 62)]
        /* 0x7DE */ public bool Imposter;
        [NMS(Index = 71)]
        /* 0x7DF */ public bool InvertAlpha;
        [NMS(Index = 49)]
        /* 0x7E0 */ public bool MatchGroundColour;
        [NMS(Index = 60)]
        /* 0x7E1 */ public bool MergedMeshBillboard;
        [NMS(Index = 16)]
        /* 0x7E2 */ public bool Metallic;
        [NMS(Index = 17)]
        /* 0x7E3 */ public bool MetallicMask;
        [NMS(Index = 32)]
        /* 0x7E4 */ public bool MultiplySecondUVSet;
        [NMS(Index = 43)]
        /* 0x7E5 */ public bool Multitexture;
        [NMS(Index = 106)]
        /* 0x7E6 */ public bool ParallaxMapped;
        [NMS(Index = 8)]
        /* 0x7E7 */ public bool ReceiveShadow;
        [NMS(Index = 76)]
        /* 0x7E8 */ public bool ReflectionProbe;
        [NMS(Index = 101)]
        /* 0x7E9 */ public bool RefractionMask;
        [NMS(Index = 59)]
        /* 0x7EA */ public bool RotateAroundAt;
        [NMS(Index = 13)]
        /* 0x7EB */ public bool RoughnessMask;
        [NMS(Index = 63)]
        /* 0x7EC */ public bool ScanEffect;
        [NMS(Index = 75)]
        /* 0x7ED */ public bool ScreenSpaceReflections;
        [NMS(Index = 109)]
        /* 0x7EE */ public bool SelfShadow;
        [NMS(Index = 10)]
        /* 0x7EF */ public bool ShadowOnly;
        [NMS(Index = 81)]
        /* 0x7F0 */ public bool SimulatedCloth;
        [NMS(Index = 36)]
        /* 0x7F1 */ public bool SpaceObject;
        [NMS(Index = 18)]
        /* 0x7F2 */ public bool SubsurfaceMask;
        [NMS(Index = 2)]
        /* 0x7F3 */ public bool Transparent;
        [NMS(Index = 11)]
        /* 0x7F4 */ public bool UISurface;
        [NMS(Index = 7)]
        /* 0x7F5 */ public bool Unlit;
        [NMS(Index = 95)]
        /* 0x7F6 */ public bool UVAnimation;
        [NMS(Index = 89)]
        /* 0x7F7 */ public bool UVScrolling;
        [NMS(Index = 96)]
        /* 0x7F8 */ public bool UVTileAlts;
        [NMS(Index = 5)]
        /* 0x7F9 */ public bool VertexColour;
        [NMS(Index = 33)]
        /* 0x7FA */ public bool VertexDetailBlend;
        [NMS(Index = 67)]
        /* 0x7FB */ public bool WarpedDiffuseLighting;
        [NMS(Index = 47)]
        /* 0x7FC */ public bool Wind;
        [NMS(Index = 64)]
        /* 0x7FD */ public bool WriteLogZ;
    }
}
