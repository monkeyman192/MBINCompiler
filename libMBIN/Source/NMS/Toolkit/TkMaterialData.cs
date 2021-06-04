using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x2E0, GUID = 0xB3E85714C2E13A19, NameHash = 0xCEE695A798E64B92)]
    public class TkMaterialData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Name;
        /* 0x080 */ public NMSString0x100 Metamaterial;
        /* 0x180 */ public NMSString0x20 Class;
        /* 0x1A0 */ public int TransparencyLayerID;
        /* 0x1A4 */ public bool CastShadow;
        /* 0x1A5 */ public bool DisableZTest;
        /* 0x1A6 */ public bool CreateFur;
        /* 0x1A7 */ public NMSString0x80 Link;
        /* 0x227 */ public NMSString0x80 Shader;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x2A7 */ public byte[] Padding1A7;
        /* 0x2A8 */ public List<TkMaterialFlags> Flags;
        /* 0x2B8 */ public List<TkMaterialUniform> Uniforms;
        /* 0x2C8 */ public List<TkMaterialSampler> Samplers;
        /* 0x2D8 */ public long ShaderMillDataHash;
    }
}
