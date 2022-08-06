using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x829BC54E2E108D7, NameHash = 0xE5F4152C8F8FC861)]
    public class TkMaterialShaderMillData : NMSTemplate
    {
        /* 0x00 */ public List<TkMaterialShaderMillNode> ShaderMillNodes;
        /* 0x10 */ public List<TkMaterialShaderMillLink> ShaderMillLinks;
        /* 0x20 */ public List<TkMaterialShaderMillFlag> ShaderMillFlags;
        /* 0x30 */ public List<TkMaterialShaderMillComment> ShaderMillCmts;
        /* 0x40 */ public float ScrollX;
        /* 0x44 */ public float ScrollY;
        /* 0x48 */ public float Zoom;
        /* 0x4C */ public int OutputX;
        /* 0x50 */ public int OutputY;
    }
}
