using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x2E0, GUID = 0x306B1AB3B7E7B836, NameHash = 0xCEE695A798E64B92)]
    public class TkMaterialData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Name;
        [NMS(Size = 0x100)]
        /* 0x080 */ public string Metamaterial;
        [NMS(Size = 0x20)]
        /* 0x180 */ public string Class;
        /* 0x1A0 */ public int TransparencyLayerID;
        /* 0x1A4 */ public bool CastShadow;
        /* 0x1A5 */ public bool DisableZTest;
        [NMS(Size = 0x80)]
        /* 0x1A6 */ public string Link;
        [NMS(Size = 0x80)]
        /* 0x226 */ public string Shader;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x2A6 */ public byte[] Padding1A6;
        /* 0x2A8 */ public List<TkMaterialFlags> Flags;
        /* 0x2B8 */ public List<TkMaterialUniform> Uniforms;
        /* 0x2C8 */ public List<TkMaterialSampler> Samplers;
        /* 0x2D8 */ public long SketchDataHash;
    }
}
