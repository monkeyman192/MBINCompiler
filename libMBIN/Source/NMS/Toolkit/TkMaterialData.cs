using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x432FC96DE69D9BA9, NameHash = 0xCEE695A798E64B92)]
    public class TkMaterialData : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x000 */ public List<TkMaterialFlags> Flags;
        [NMS(Index = 11)]
        /* 0x010 */ public List<TkMaterialSampler> Samplers;
        [NMS(Index = 10)]
        /* 0x020 */ public List<TkMaterialUniform> Uniforms;
        [NMS(Index = 12)]
        /* 0x030 */ public long ShaderMillDataHash;
        [NMS(Index = 3)]
        /* 0x038 */ public int TransparencyLayerID;
        [NMS(Index = 1)]
        /* 0x03C */ public NMSString0x100 Metamaterial;
        [NMS(Index = 7)]
        /* 0x13C */ public NMSString0x80 Link;
        [NMS(Index = 0)]
        /* 0x1BC */ public NMSString0x80 Name;
        [NMS(Index = 8)]
        /* 0x23C */ public NMSString0x80 Shader;
        [NMS(Index = 2)]
        /* 0x2BC */ public NMSString0x20 Class;
        [NMS(Index = 4)]
        /* 0x2DC */ public bool CastShadow;
        [NMS(Index = 6)]
        /* 0x2DD */ public bool CreateFur;
        [NMS(Index = 5)]
        /* 0x2DE */ public bool DisableZTest;
    }
}
