using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x432FC96DE69D9BA9, NameHash = 0xCEE695A798E64B92)]
    public class TkMaterialData : NMSTemplate
    {
        /* 0x000 */ public List<TkMaterialFlags> Flags;
        /* 0x010 */ public List<TkMaterialSampler> Samplers;
        /* 0x020 */ public List<TkMaterialUniform> Uniforms;
        /* 0x030 */ public long ShaderMillDataHash;
        /* 0x038 */ public int TransparencyLayerID;
        /* 0x03C */ public NMSString0x100 Metamaterial;
        /* 0x13C */ public NMSString0x80 Link;
        /* 0x1BC */ public NMSString0x80 Name;
        /* 0x23C */ public NMSString0x80 Shader;
        /* 0x2BC */ public NMSString0x20 Class;
        /* 0x2DC */ public bool CastShadow;
        /* 0x2DD */ public bool CreateFur;
        /* 0x2DE */ public bool DisableZTest;
    }
}
