using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x41CC276B249A87F8, NameHash = 0xB36368E9)]
    public class TkMaterialMetaData : NMSTemplate
    {
        [NMS(Index = 133, MxmlName = "Fog Volume Colour")]
        /* 0x000 */ public Colour FogVolumeColour;
        [NMS(Index = 126, MxmlName = "Wave One Amplitude")]
        /* 0x010 */ public Vector3f WaveOneAmplitude;
        [NMS(Index = 128, MxmlName = "Wave One Fall Off")]
        /* 0x020 */ public Vector3f WaveOneFallOff;
        [NMS(Index = 127, MxmlName = "Wave One Frequency")]
        /* 0x030 */ public Vector3f WaveOneFrequency;
        [NMS(Index = 130, MxmlName = "Wave Two Amplitude")]
        /* 0x040 */ public Vector3f WaveTwoAmplitude;
        [NMS(Index = 132, MxmlName = "Wave Two Fall Off")]
        /* 0x050 */ public Vector3f WaveTwoFallOff;
        [NMS(Index = 131, MxmlName = "Wave Two Frequency")]
        /* 0x060 */ public Vector3f WaveTwoFrequency;
        [NMS(Index = 139)]
        /* 0x070 */ public TkMaterialShaderMillData ShaderMillData;
        [NMS(Index = 35)]
        /* 0x308 */ public GcFilename DetailNormal;
        [NMS(Index = 0)]
        /* 0x318 */ public GcFilename ExternalMaterial;
        [NMS(Index = 30)]
        /* 0x328 */ public GcFilename ForceDiffuse;
        [NMS(Index = 34)]
        /* 0x338 */ public GcFilename ForceFeature;
        [NMS(Index = 32)]
        /* 0x348 */ public GcFilename ForceMask;
        [NMS(Index = 33)]
        /* 0x358 */ public GcFilename ForceMaskExt;
        [NMS(Index = 31)]
        /* 0x368 */ public GcFilename ForceNormal;
        [NMS(Index = 65)]
        /* 0x378 */ public float BillboardSphereFactor;
        [NMS(Index = 51, MxmlName = "Branch H Swing")]
        /* 0x37C */ public float BranchHSwing;
        [NMS(Index = 52, MxmlName = "Branch Trunk Anim")]
        /* 0x380 */ public float BranchTrunkAnim;
        [NMS(Index = 50, MxmlName = "Branch V Swing")]
        /* 0x384 */ public float BranchVSwing;
        [NMS(Index = 38, MxmlName = "Detail Height Blend")]
        /* 0x388 */ public float DetailHeightBlend;
        [NMS(Index = 39, MxmlName = "Detail Height Boost")]
        /* 0x38C */ public float DetailHeightBoost;
        [NMS(Index = 134, MxmlName = "Fog Volume Density")]
        /* 0x390 */ public float FogVolumeDensity;
        [NMS(Index = 136, MxmlName = "Fog Volume Fade")]
        /* 0x394 */ public float FogVolumeFade;
        [NMS(Index = 137, MxmlName = "Fog Volume Noise Scale")]
        /* 0x398 */ public float FogVolumeNoiseScale;
        [NMS(Index = 95)]
        /* 0x39C */ public float FurNoiseScale;
        [NMS(Index = 96)]
        /* 0x3A0 */ public float FurNoiseThickness;
        [NMS(Index = 97)]
        /* 0x3A4 */ public float FurNoiseTurbulence;
        [NMS(Index = 98)]
        /* 0x3A8 */ public float FurTurbulenceScale;
        [NMS(Index = 21)]
        /* 0x3AC */ public float Glow;
        [NMS(Index = 53, MxmlName = "Height Scale")]
        /* 0x3B0 */ public float HeightScale;
        [NMS(Index = 27, MxmlName = "IBL Weight")]
        /* 0x3B4 */ public float IBLWeight;
        [NMS(Index = 55, MxmlName = "Leaf Noise")]
        /* 0x3B8 */ public float LeafNoise;
        [NMS(Index = 56, MxmlName = "Leaf Swing")]
        /* 0x3BC */ public float LeafSwing;
        [NMS(Index = 40, MxmlName = "Normal Tiling")]
        /* 0x3C0 */ public float NormalTiling;
        [NMS(Index = 119, MxmlName = "Num Steps")]
        /* 0x3C4 */ public int NumSteps;
        [NMS(Index = 118, MxmlName = "Parallax Depth")]
        /* 0x3C8 */ public float ParallaxDepth;
        [NMS(Index = 115, MxmlName = "Particle Refraction Brightness Multiplier")]
        /* 0x3CC */ public float ParticleRefractionBrightnessMultiplier;
        [NMS(Index = 113, MxmlName = "Particle Refraction Strength X")]
        /* 0x3D0 */ public float ParticleRefractionStrengthX;
        [NMS(Index = 114, MxmlName = "Particle Refraction Strength Y")]
        /* 0x3D4 */ public float ParticleRefractionStrengthY;
        [NMS(Index = 116, MxmlName = "Particle Refraction Tint")]
        /* 0x3D8 */ public float ParticleRefractionTint;
        [NMS(Index = 83)]
        /* 0x3DC */ public float ReactivityBias;
        [NMS(Index = 19)]
        /* 0x3E0 */ public float Reflectance;
        [NMS(Index = 110)]
        /* 0x3E4 */ public float Refraction;
        [NMS(Index = 111, MxmlName = "Refraction Index")]
        /* 0x3E8 */ public float RefractionIndex;
        [NMS(Index = 13)]
        /* 0x3EC */ public float Roughness;
        // size: 0x8
        public enum ShaderEnum : uint {
            UberShader,
            Sky,
            Screen,
            UberHack,
            UIScreen,
            Decal,
            Particle,
            ReflectionProbe,
        }
        [NMS(Index = 1)]
        /* 0x3F0 */ public ShaderEnum Shader;
        [NMS(Index = 121, MxmlName = "Shadow Factor")]
        /* 0x3F4 */ public float ShadowFactor;
        [NMS(Index = 94)]
        /* 0x3F8 */ public float ShellsHeight;
        [NMS(Index = 59)]
        /* 0x3FC */ public float SoftFadeStrength;
        [NMS(Index = 17)]
        /* 0x400 */ public float Subsurface;
        [NMS(Index = 58)]
        /* 0x404 */ public float TerrainNormalFactor;
        [NMS(Index = 71)]
        /* 0x408 */ public float TessellationHeight;
        [NMS(Index = 85)]
        /* 0x40C */ public float TopBlend;
        [NMS(Index = 86)]
        /* 0x410 */ public float TopBlendOffset;
        [NMS(Index = 87)]
        /* 0x414 */ public float TopBlendSharpness;
        [NMS(Index = 4)]
        /* 0x418 */ public int TransparencyLayerID;
        [NMS(Index = 54, MxmlName = "Trunk Bend")]
        /* 0x41C */ public float TrunkBend;
        [NMS(Index = 105, MxmlName = "UV Frame Time")]
        /* 0x420 */ public float UVFrameTime;
        [NMS(Index = 108, MxmlName = "UV Num Tiles X")]
        /* 0x424 */ public float UVNumTilesX;
        [NMS(Index = 109, MxmlName = "UV Num Tiles Y")]
        /* 0x428 */ public float UVNumTilesY;
        [NMS(Index = 103, MxmlName = "UV Scroll Normal X")]
        /* 0x42C */ public float UVScrollNormalX;
        [NMS(Index = 104, MxmlName = "UV Scroll Normal Y")]
        /* 0x430 */ public float UVScrollNormalY;
        [NMS(Index = 101, MxmlName = "UV Scroll X")]
        /* 0x434 */ public float UVScrollX;
        [NMS(Index = 102, MxmlName = "UV Scroll Y")]
        /* 0x438 */ public float UVScrollY;
        [NMS(Index = 125, MxmlName = "Wave One Speed")]
        /* 0x43C */ public float WaveOneSpeed;
        [NMS(Index = 129, MxmlName = "Wave Two Speed")]
        /* 0x440 */ public float WaveTwoSpeed;
        [NMS(Index = 5)]
        /* 0x444 */ public bool Additive;
        [NMS(Index = 48, MxmlName = "Alpha Cutout")]
        /* 0x445 */ public bool AlphaCutout;
        [NMS(Index = 76)]
        /* 0x446 */ public bool AlwaysOnTopUI;
        [NMS(Index = 70)]
        /* 0x447 */ public bool AnisotropicFilter;
        [NMS(Index = 23, MxmlName = "Anisotropy Mask")]
        /* 0x448 */ public bool AnisotropyMask;
        [NMS(Index = 24, MxmlName = "AO Map")]
        /* 0x449 */ public bool AOMap;
        [NMS(Index = 74)]
        /* 0x44A */ public bool BeforeUI;
        [NMS(Index = 25, MxmlName = "Bent Normals")]
        /* 0x44B */ public bool BentNormals;
        [NMS(Index = 62)]
        /* 0x44C */ public bool Billboard;
        [NMS(Index = 42, MxmlName = "Bright Edge")]
        /* 0x44D */ public bool BrightEdge;
        [NMS(Index = 43)]
        /* 0x44E */ public bool CameraRelative;
        [NMS(Index = 11, MxmlName = "Cast Shadow")]
        /* 0x44F */ public bool CastShadow;
        [NMS(Index = 44)]
        /* 0x450 */ public bool Colourisable;
        [NMS(Index = 45)]
        /* 0x451 */ public bool ColourMask;
        [NMS(Index = 93)]
        /* 0x452 */ public bool CreateFur;
        [NMS(Index = 90)]
        /* 0x453 */ public bool DecalNormalOnly;
        [NMS(Index = 92)]
        /* 0x454 */ public bool DecalTerrainOnly;
        [NMS(Index = 91)]
        /* 0x455 */ public bool DecalWriteMaterial;
        [NMS(Index = 75)]
        /* 0x456 */ public bool DepthMaskUI;
        [NMS(Index = 122, MxmlName = "Diffuse Only")]
        /* 0x457 */ public bool DiffuseOnly;
        [NMS(Index = 69)]
        /* 0x458 */ public bool DisablePostProcess;
        [NMS(Index = 7)]
        /* 0x459 */ public bool DisableZTest;
        [NMS(Index = 124, MxmlName = "Displacement Position Offset")]
        /* 0x45A */ public bool DisplacementPositionOffset;
        [NMS(Index = 123, MxmlName = "Displacement Wave")]
        /* 0x45B */ public bool DisplacementWave;
        [NMS(Index = 72)]
        /* 0x45C */ public bool Dissolve;
        [NMS(Index = 82)]
        /* 0x45D */ public bool DoubleBufferGeometry;
        [NMS(Index = 60)]
        /* 0x45E */ public bool DoubleSided;
        [NMS(Index = 61)]
        /* 0x45F */ public bool DoubleSidedKeepNormals;
        [NMS(Index = 80)]
        /* 0x460 */ public bool DrawToBloom;
        [NMS(Index = 81)]
        /* 0x461 */ public bool DrawToLensFlare;
        [NMS(Index = 77)]
        /* 0x462 */ public bool EnableLodFade;
        [NMS(Index = 47, MxmlName = "Feature Map")]
        /* 0x463 */ public bool FeatureMap;
        [NMS(Index = 138, MxmlName = "Fog Volume Wind Enabled")]
        /* 0x464 */ public bool FogVolumeWindEnabled;
        // size: 0x2
        public enum FogVolumeTypeEnum : byte {
            Box,
            Sphere,
        }
        [NMS(Index = 135)]
        /* 0x465 */ public FogVolumeTypeEnum FogVolumeType;
        [NMS(Index = 8)]
        /* 0x466 */ public bool FullPrecisionPosition;
        [NMS(Index = 22, MxmlName = "Glow Mask")]
        /* 0x467 */ public bool GlowMask;
        [NMS(Index = 99, MxmlName = "High Quality Particle")]
        /* 0x468 */ public bool HighQualityParticle;
        [NMS(Index = 26, MxmlName = "Image Based Lighting")]
        /* 0x469 */ public bool ImageBasedLighting;
        [NMS(Index = 66)]
        /* 0x46A */ public bool Imposter;
        [NMS(Index = 73)]
        /* 0x46B */ public bool InvertAlpha;
        [NMS(Index = 28, MxmlName = "Light Layers")]
        /* 0x46C */ public TkLightLayer LightLayers;
        [NMS(Index = 57)]
        /* 0x46D */ public bool MatchGroundColour;
        [NMS(Index = 64)]
        /* 0x46E */ public bool MergedMeshBillboard;
        [NMS(Index = 15)]
        /* 0x46F */ public bool Metallic;
        [NMS(Index = 16, MxmlName = "Metallic Mask")]
        /* 0x470 */ public bool MetallicMask;
        // size: 0xD
        public enum MetaMaterialClassEnum : byte {
            None,
            BlackHoleBack,
            BloomAndLensFlare,
            ExclusionVolumeConnectorSurface,
            ExclusionVolumeOutsideSurface,
            Gun,
            GunAdditive,
            GunDecal,
            GunGlow,
            GunOpaque,
            TeleportTravelMarker,
            WarpOnFoot,
            FogVolume,
        }
        [NMS(Index = 29)]
        /* 0x471 */ public MetaMaterialClassEnum MetaMaterialClass;
        [NMS(Index = 46)]
        /* 0x472 */ public bool Multitexture;
        [NMS(Index = 117, MxmlName = "Parallax Mapped")]
        /* 0x473 */ public bool ParallaxMapped;
        [NMS(Index = 10, MxmlName = "Receive Shadow")]
        /* 0x474 */ public bool ReceiveShadow;
        [NMS(Index = 20, MxmlName = "Reflectance Mask")]
        /* 0x475 */ public bool ReflectanceMask;
        [NMS(Index = 79)]
        /* 0x476 */ public bool ReflectionProbe;
        [NMS(Index = 112, MxmlName = "Refraction Mask")]
        /* 0x477 */ public bool RefractionMask;
        [NMS(Index = 63)]
        /* 0x478 */ public bool RotateAroundAt;
        [NMS(Index = 14, MxmlName = "Roughness Mask")]
        /* 0x479 */ public bool RoughnessMask;
        [NMS(Index = 67)]
        /* 0x47A */ public bool ScanEffect;
        [NMS(Index = 78)]
        /* 0x47B */ public bool ScreenSpaceReflections;
        [NMS(Index = 120, MxmlName = "Self Shadow")]
        /* 0x47C */ public bool SelfShadow;
        [NMS(Index = 12, MxmlName = "Shadow Only")]
        /* 0x47D */ public bool ShadowOnly;
        [NMS(Index = 84)]
        /* 0x47E */ public bool SimulatedCloth;
        [NMS(Index = 18, MxmlName = "Subsurface Mask")]
        /* 0x47F */ public bool SubsurfaceMask;
        [NMS(Index = 88)]
        /* 0x480 */ public bool TopBlendFlip;
        [NMS(Index = 89)]
        /* 0x481 */ public bool TopBlendUseBaseNormal;
        [NMS(Index = 3)]
        /* 0x482 */ public bool Transparent;
        [NMS(Index = 41, MxmlName = "UI Surface")]
        /* 0x483 */ public bool UISurface;
        [NMS(Index = 9)]
        /* 0x484 */ public bool Unlit;
        [NMS(Index = 2)]
        /* 0x485 */ public bool UseShaderMill;
        [NMS(Index = 106, MxmlName = "UV Animation")]
        /* 0x486 */ public bool UVAnimation;
        [NMS(Index = 100, MxmlName = "UV Scrolling")]
        /* 0x487 */ public bool UVScrolling;
        [NMS(Index = 107, MxmlName = "UV Tile Alts")]
        /* 0x488 */ public bool UVTileAlts;
        [NMS(Index = 36, MxmlName = "Vertex Alpha  AO")]
        /* 0x489 */ public bool VertexAlphaAO;
        [NMS(Index = 6, MxmlName = "Vertex Colour")]
        /* 0x48A */ public bool VertexColour;
        [NMS(Index = 37, MxmlName = "Vertex Detail Blend")]
        /* 0x48B */ public bool VertexDetailBlend;
        [NMS(Index = 49)]
        /* 0x48C */ public bool Wind;
        [NMS(Index = 68)]
        /* 0x48D */ public bool WriteLogZ;
    }
}
