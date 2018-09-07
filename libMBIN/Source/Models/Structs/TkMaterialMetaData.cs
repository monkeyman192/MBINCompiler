using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class TkMaterialMetaData : NMSTemplate       // size: 0x420;
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string ExternalMaterial;
		public enum ShaderEnum { UberShader, Sky, Screen, UberHack }
		public ShaderEnum Shader;
        /* 0x084 */ public bool Transaprent;
        /* 0x088 */ public int TransparencyLayerID;
        /* 0x08C */ public bool Additive;
        /* 0x08D */ public bool VertexColour;
        /* 0x08E */ public bool DisableZTest;
        /* 0x08F */ public bool Unlit;
        /* 0x090 */ public bool ReceiveShadow;
        /* 0x091 */ public bool CastShadow;
        /* 0x092 */ public bool ShadowOnly;
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
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x31E */ public byte[] Padding31E;
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
        /* 0x344 */ public bool AlphaCutout;
        /* 0x345 */ public bool Wind;
        /* 0x346 */ public bool Grass;
        /* 0x347 */ public bool Leaf;
        /* 0x348 */ public bool DecalDiffuse;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x349 */ public byte[] Padding1C9;
		public enum DecalNormalEnum { None, Decal, Vertex }
		public DecalNormalEnum DecalNormal;
        /* 0x350 */ public bool DoubleSided;
        /* 0x351 */ public bool Billboard;
        /* 0x352 */ public bool RotateAroundAt;
        /* 0x353 */ public bool MergedMeshBillboard;
        /* 0x354 */ public float BillboardSphereFactor;
        /* 0x358 */ public bool Imposter;
        /* 0x359 */ public bool ScanEffect;
        /* 0x35A */ public bool WriteLogZ;

        /* 0x35B */ public bool DisableAmbient;
        /* 0x35C */ public bool DisablePostProcess;
        /* 0x35D */ public bool WarpedDiffuseLighting;
        [NMS(Size = 0x20)]
        /* 0x35E */ public string MaterialClass;
        /* 0x37E */ public bool AnisotropicFilter;
        /* 0x37F */ public bool StretchyParticle;
        /* 0x380 */ public bool UVScrolling;
        /* 0x384 */ public float UVScrollX;
        /* 0x388 */ public float UVScrollY;
        /* 0x38C */ public float UVScrollNormalX;
        /* 0x390 */ public float UVScrollNormalY;
        /* 0x394 */ public float UVFrameTime;
        /* 0x398 */ public bool UVAnimation;
        /* 0x399 */ public bool UVTileAlts;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x39A */ public byte[] Padding3A;
        /* 0x39C */ public float UVNumTilesX;
        /* 0x3A0 */ public float UVNumTilesY;
        /* 0x3A4 */ public bool DisplacementWave;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x3A5 */ public byte[] Padding3A5;
        /* 0x3A8 */ public float WaveOneSpeed;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x3AC */ public byte[] Padding3AC;
        /* 0x3B0 */ public Vector4f WaveOneAmplitude;
        /* 0x3C0 */ public Vector4f WaveOneFrequency;
        /* 0x3D0 */ public Vector4f WaveOneFallOff;
        /* 0x3E0 */ public float WaveTwoSpeed;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x3E4 */ public byte[] Padding3E4;
        /* 0x3F0 */ public Vector4f WaveTwoAmplitude;
        /* 0x400 */ public Vector4f WaveTwoFrequency;
        /* 0x410 */ public Vector4f WaveTwoFallOff;
    }
}
