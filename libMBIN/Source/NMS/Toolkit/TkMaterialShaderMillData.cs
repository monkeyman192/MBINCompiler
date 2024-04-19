using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD617F7F352D5E186, NameHash = 0xE5F4152C8F8FC861)]
    public class TkMaterialShaderMillData : NMSTemplate
    {
        /* 0x000 */ public List<TkMaterialShaderMillComment> ShaderMillCmts;
        /* 0x010 */ public List<TkMaterialShaderMillFlag> ShaderMillFlags;
        /* 0x020 */ public List<TkMaterialShaderMillLink> ShaderMillLinks;
        /* 0x030 */ public List<TkMaterialShaderMillNode> ShaderMillNodes;
        /* 0x040 */ public int OutputX;
        /* 0x044 */ public int OutputY;
        /* 0x048 */ public float ScrollX;
        /* 0x04C */ public float ScrollY;
        /* 0x050 */ public float Zoom;
        /* 0x054 */ public NMSString0x200 Description;
        /* 0x254 */ public NMSString0x80 Filename;
        /* 0x2D4 */ public NMSString0x40 Name;
    }
}
