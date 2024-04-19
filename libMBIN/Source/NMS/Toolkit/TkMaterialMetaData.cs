using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x83268F02FC4A5E72, NameHash = 0xE39CB7AA4D818260)]
    public class TkMaterialMetaData : NMSTemplate
    {
        /* 0x000 */ public Vector3f WaveOneAmplitude;
        /* 0x010 */ public Vector3f WaveOneFallOff;
        /* 0x020 */ public Vector3f WaveOneFrequency;
        /* 0x030 */ public Vector3f WaveTwoAmplitude;
        /* 0x040 */ public Vector3f WaveTwoFallOff;
        /* 0x050 */ public Vector3f WaveTwoFrequency;
        /* 0x060 */ public TkMaterialShaderMillData ShaderMillData;
        /* 0x378 */ public float BillboardSphereFactor;
        // size: 0x3
        public enum DecalNormalEnum : uint {
            None,
            Decal,
            Vertex,
        }
        /* 0x37C */ public DecalNormalEnum DecalNormal;
        /* 0x380 */ public float DetailHeightBlend;
        /* 0x384 */ public int DetailImages;
        /* 0x388 */ public float DetailTiling;
        /* 0x38C */ public float FurNoiseScale;
        /* 0x390 */ public float FurNoiseThickness;
        /* 0x394 */ public float FurNoiseTurbulence;
        /* 0x398 */ public float FurTurbulenceScale;
        /* 0x39C */ public float Glow;
        /* 0x3A0 */ public float IBLWeight;
        /* 0x3A4 */ public int MultiplyDetailImages;
        /* 0x3A8 */ public float MultiplyDetailTiling;
        /* 0x3AC */ public float NormalTiling;
        /* 0x3B0 */ public int NumSteps;
        /* 0x3B4 */ public float ParallaxDepth;
        /* 0x3B8 */ public float ParticleRefractionBrightnessMultiplier;
        /* 0x3BC */ public float ParticleRefractionStrengthX;
        /* 0x3C0 */ public float ParticleRefractionStrengthY;
        /* 0x3C4 */ public float ParticleRefractionTint;
        /* 0x3C8 */ public float ReactivityBias;
        /* 0x3CC */ public float Refraction;
        /* 0x3D0 */ public float RefractionIndex;
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
        /* 0x3D8 */ public ShaderEnum Shader;
        /* 0x3DC */ public float ShadowFactor;
        /* 0x3E0 */ public float ShellsHeight;
        /* 0x3E4 */ public float SoftFadeStrength;
        /* 0x3E8 */ public float SubsurfaceWeight;
        /* 0x3EC */ public float TerrainNormalFactor;
        /* 0x3F0 */ public float TessellationHeight;
        /* 0x3F4 */ public int TransparencyLayerID;
        /* 0x3F8 */ public float UVFrameTime;
        /* 0x3FC */ public float UVNumTilesX;
        /* 0x400 */ public float UVNumTilesY;
        /* 0x404 */ public float UVScrollNormalX;
        /* 0x408 */ public float UVScrollNormalY;
        /* 0x40C */ public float UVScrollX;
        /* 0x410 */ public float UVScrollY;
        /* 0x414 */ public float WaveOneSpeed;
        /* 0x418 */ public float WaveTwoSpeed;
        /* 0x41C */ public NMSString0x80 DetailDiffuse;
        /* 0x49C */ public NMSString0x80 DetailNormal;
        /* 0x51C */ public NMSString0x80 ExternalMaterial;
        /* 0x59C */ public NMSString0x80 ForceDiffuse;
        /* 0x61C */ public NMSString0x80 ForceFeature;
        /* 0x69C */ public NMSString0x80 ForceMask;
        /* 0x71C */ public NMSString0x80 ForceNormal;
        /* 0x79C */ public NMSString0x20 MaterialClass;
        /* 0x7BC */ public bool AcuteAngleFadeOut;
        /* 0x7BD */ public bool Additive;
        /* 0x7BE */ public bool AlphaCutout;
        /* 0x7BF */ public bool AlwaysOnTopUI;
        /* 0x7C0 */ public bool AnisotropicFilter;
        /* 0x7C1 */ public bool AOMap;
        /* 0x7C2 */ public bool BeforeUI;
        /* 0x7C3 */ public bool Billboard;
        /* 0x7C4 */ public bool BrightEdge;
        /* 0x7C5 */ public bool CameraRelative;
        /* 0x7C6 */ public bool CastShadow;
        /* 0x7C7 */ public bool ClampAmbientLight;
        /* 0x7C8 */ public bool Colourisable;
        /* 0x7C9 */ public bool ColourMask;
        /* 0x7CA */ public bool CreateFur;
        /* 0x7CB */ public bool DecalDiffuse;
        /* 0x7CC */ public bool DecalTerrainOnly;
        /* 0x7CD */ public bool DepthMaskUI;
        /* 0x7CE */ public bool DetailedAlphaCutout;
        /* 0x7CF */ public bool DisableAmbient;
        /* 0x7D0 */ public bool DisablePostProcess;
        /* 0x7D1 */ public bool DisableZTest;
        /* 0x7D2 */ public bool DisplacementPositionOffset;
        /* 0x7D3 */ public bool DisplacementWave;
        /* 0x7D4 */ public bool Dissolve;
        /* 0x7D5 */ public bool DoubleBufferGeometry;
        /* 0x7D6 */ public bool DoubleSided;
        /* 0x7D7 */ public bool DrawToBloom;
        /* 0x7D8 */ public bool DrawToLensFlare;
        /* 0x7D9 */ public bool EnvironmentalOverlay;
        /* 0x7DA */ public bool FeatureMap;
        /* 0x7DB */ public bool GlowMask;
        /* 0x7DC */ public bool HighQualityParticle;
        /* 0x7DD */ public bool ImageBasedLighting;
        /* 0x7DE */ public bool Imposter;
        /* 0x7DF */ public bool InvertAlpha;
        /* 0x7E0 */ public bool MatchGroundColour;
        /* 0x7E1 */ public bool MergedMeshBillboard;
        /* 0x7E2 */ public bool Metallic;
        /* 0x7E3 */ public bool MetallicMask;
        /* 0x7E4 */ public bool MultiplySecondUVSet;
        /* 0x7E5 */ public bool Multitexture;
        /* 0x7E6 */ public bool ParallaxMapped;
        /* 0x7E7 */ public bool ReceiveShadow;
        /* 0x7E8 */ public bool ReflectionProbe;
        /* 0x7E9 */ public bool RefractionMask;
        /* 0x7EA */ public bool RotateAroundAt;
        /* 0x7EB */ public bool RoughnessMask;
        /* 0x7EC */ public bool ScanEffect;
        /* 0x7ED */ public bool ScreenSpaceReflections;
        /* 0x7EE */ public bool SelfShadow;
        /* 0x7EF */ public bool ShadowOnly;
        /* 0x7F0 */ public bool SimulatedCloth;
        /* 0x7F1 */ public bool SpaceObject;
        /* 0x7F2 */ public bool SubsurfaceMask;
        /* 0x7F3 */ public bool Transparent;
        /* 0x7F4 */ public bool UISurface;
        /* 0x7F5 */ public bool Unlit;
        /* 0x7F6 */ public bool UVAnimation;
        /* 0x7F7 */ public bool UVScrolling;
        /* 0x7F8 */ public bool UVTileAlts;
        /* 0x7F9 */ public bool VertexColour;
        /* 0x7FA */ public bool VertexDetailBlend;
        /* 0x7FB */ public bool WarpedDiffuseLighting;
        /* 0x7FC */ public bool Wind;
        /* 0x7FD */ public bool WriteLogZ;
    }
}
