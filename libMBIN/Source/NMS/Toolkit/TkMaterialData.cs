using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x2E0, GUID = 0x61E6156B7B668D85, NameHash = 0xCEE695A798E64B92)]
    public class TkMaterialData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Name;
        /* 0x080 */ public NMSString0x100 Metamaterial;
        /* 0x180 */ public NMSString0x20 Class;
        /* 0x1A0 */ public int TransparencyLayerID;
        /* 0x1A4 */ public bool CastShadow;
        /* 0x1A5 */ public bool DisableZTest;
        /* 0x1A6 */ public NMSString0x80 Link;
        /* 0x226 */ public NMSString0x80 Shader;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x2A6 */ public byte[] Padding1A6;
        /* 0x2A8 */ public List<TkMaterialFlags> Flags;
        /* 0x2B8 */ public List<TkMaterialUniform> Uniforms;
        /* 0x2C8 */ public List<TkMaterialSampler> Samplers;
        /* 0x2D8 */ public long ShaderMillDataHash;
    }
}
