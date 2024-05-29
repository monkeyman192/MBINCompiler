using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1253A72456AF232C, NameHash = 0xCEE695A798E64B92)]
    public class TkMaterialData : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x00 */ public List<TkMaterialFlags> Flags;
        [NMS(Index = 7)]
        /* 0x10 */ public VariableSizeString Link;
        [NMS(Index = 1)]
        /* 0x20 */ public VariableSizeString Metamaterial;
        [NMS(Index = 0)]
        /* 0x30 */ public VariableSizeString Name;
        [NMS(Index = 11)]
        /* 0x40 */ public List<TkMaterialSampler> Samplers;
        [NMS(Index = 8)]
        /* 0x50 */ public VariableSizeString Shader;
        [NMS(Index = 10)]
        /* 0x60 */ public List<TkMaterialUniform> Uniforms;
        [NMS(Index = 12)]
        /* 0x70 */ public long ShaderMillDataHash;
        [NMS(Index = 3)]
        /* 0x78 */ public int TransparencyLayerID;
        [NMS(Index = 2)]
        /* 0x7C */ public NMSString0x20 Class;
        [NMS(Index = 4)]
        /* 0x9C */ public bool CastShadow;
        [NMS(Index = 6)]
        /* 0x9D */ public bool CreateFur;
        [NMS(Index = 5)]
        /* 0x9E */ public bool DisableZTest;
    }
}
