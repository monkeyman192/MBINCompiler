using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class TkMaterialMetaData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string ExternalMaterial;
        public int Shader;
        /* 0x080 */ public string[] ShaderValues()
        {
            return new[] { "UberShader", "Sky", "Screen", "UberHack" };
        }
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
        /* 0x09E */ public string DetailDiffuse;
        [NMS(Size = 0x80)]
        /* 0x11E */ public string DetailNormal;
        /* 0x1A0 */ public float DetailTiling;
        /* 0x1A4 */ public float MultiplyDetailTiling;
        /* 0x1A8 */ public int DetailImages;
        /* 0x1AC */ public int MultiplyDetailImages;
        /* 0x1B0 */ public bool A0Map;
        /* 0x1B1 */ public bool MultiplySecondUVSet;
        /* 0x1B4 */ public float NormalTiling;
        /* 0x1B8 */ public bool SpaceObject;
        /* 0x1BC */ public float Glow;
        /* 0x1C0 */ public bool GlowMask;
        /* 0x1C1 */ public bool CameraRelative;
        /* 0x1C2 */ public bool Colourisable;
        /* 0x1C3 */ public bool ColourMask;
        /* 0x1C4 */ public bool AlphaCutout;
        /* 0x1C5 */ public bool Wind;
        /* 0x1C6 */ public bool Grass;
        /* 0x1C7 */ public bool Leaf;
        /* 0x1C8 */ public bool DecalDiffuse;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x1C9 */ public byte[] Padding1C9;
        public int DecalNormal;
        /* 0x1CC */ public string[] DecalNormalValues()
        {
            return new[] { "None", "Decal", "Vertex" };
        }
        /* 0x1D0 */ public bool DoubleSided;
        /* 0x1D1 */ public bool Billboard;
        /* 0x1D2 */ public bool RotateAroundAt;
        /* 0x1D3 */ public bool MergedMeshBillboard;
        /* 0x1D4 */ public float BillboardSphereFactor;
        /* 0x1D8 */ public bool Imposter;
        /* 0x1D9 */ public bool ScanEffect;
        /* 0x1DA */ public bool WriteLogZ;

        /* 0x1DB */ public bool DisableAmbient;
        /* 0x1DC */ public bool DisablePostProcess;
        /* 0x1DD */ public bool WarpedDiffuseLighting;
        [NMS(Size = 0x20)]
        /* 0x1DE */ public string MaterialClass;
        /* 0x1FE */ public bool AnisotropicFilter;
        /* 0x1FF */ public bool StretchyParticle;
        /* 0x200 */ public bool UVScrolling;
        /* 0x204 */ public float UVScrollX;
        /* 0x208 */ public float UVScrollY;
        /* 0x20C */ public float UVScrollNormalX;
        /* 0x210 */ public float UVScrollNormalY;
        /* 0x214 */ public float UVFrameTime;
        /* 0x218 */ public bool UVAnimation;
        /* 0x219 */ public bool UVTileAlts;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x21A */ public byte[] Padding21A;
        /* 0x21C */ public float UVNumTilesX;
        /* 0x220 */ public float UVNumTilesY;
        /* 0x224 */ public bool DisplacementWave;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x225 */ public byte[] Padding225;
        /* 0x228 */ public float WaveOneSpeed;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x22C */ public byte[] Padding22C;
        /* 0x230 */ public Vector4f WaveOneAmplitude;
        /* 0x240 */ public Vector4f WaveOneFrequency;
        /* 0x250 */ public Vector4f WaveOneFallOff;
        /* 0x260 */ public float WaveTwoSpeed;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x264 */ public byte[] Padding264;
        /* 0x270 */ public Vector4f WaveTwoAmplitude;
        /* 0x280 */ public Vector4f WaveTwoFrequency;
        /* 0x290 */ public Vector4f WaveTwoFallOff;
    }
}
