using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2CEDCCFC38E5F1A9, NameHash = 0x4737D48A)]
    public class TkMaterialData : NMSTemplate
    {
        [NMS(Index = 11)]
        /* 0x00 */ public List<TkMaterialFlags> Flags;
        [NMS(Index = 12)]
        /* 0x10 */ public List<TkMaterialFxFlags> FxFlags;
        [NMS(Index = 9)]
        /* 0x20 */ public GcFilename Link;
        [NMS(Index = 1)]
        /* 0x30 */ public VariableSizeString Metamaterial;
        [NMS(Index = 0)]
        /* 0x40 */ public VariableSizeString Name;
        [NMS(Index = 15)]
        /* 0x50 */ public List<TkMaterialSampler> Samplers;
        [NMS(Index = 10)]
        /* 0x60 */ public GcFilename Shader;
        [NMS(Index = 13)]
        /* 0x70 */ public List<TkMaterialUniform_Float> Uniforms_Float;
        [NMS(Index = 14)]
        /* 0x80 */ public List<TkMaterialUniform_UInt> Uniforms_UInt;
        [NMS(Index = 16)]
        /* 0x90 */ public long ShaderMillDataHash;
        [NMS(Index = 3)]
        /* 0x98 */ public int TransparencyLayerID;
        [NMS(Index = 4)]
        /* 0x9C */ public bool CastShadow;
        [NMS(Index = 2)]
        /* 0x9D */ public TkMaterialClass Class;
        [NMS(Index = 6)]
        /* 0x9E */ public bool CreateFur;
        [NMS(Index = 5)]
        /* 0x9F */ public bool DisableZTest;
        [NMS(Index = 7)]
        /* 0xA0 */ public bool EnableLodFade;
        [NMS(Index = 8)]
        /* 0xA1 */ public bool UseShaderMill;
    }
}
