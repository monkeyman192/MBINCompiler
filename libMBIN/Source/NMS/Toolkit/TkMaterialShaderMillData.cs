using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD617F7F352D5E186, NameHash = 0xE5F4152C8F8FC861)]
    public class TkMaterialShaderMillData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public List<TkMaterialShaderMillComment> ShaderMillCmts;
        [NMS(Index = 2)]
        /* 0x010 */ public List<TkMaterialShaderMillFlag> ShaderMillFlags;
        [NMS(Index = 1)]
        /* 0x020 */ public List<TkMaterialShaderMillLink> ShaderMillLinks;
        [NMS(Index = 0)]
        /* 0x030 */ public List<TkMaterialShaderMillNode> ShaderMillNodes;
        [NMS(Index = 10)]
        /* 0x040 */ public int OutputX;
        [NMS(Index = 11)]
        /* 0x044 */ public int OutputY;
        [NMS(Index = 7)]
        /* 0x048 */ public float ScrollX;
        [NMS(Index = 8)]
        /* 0x04C */ public float ScrollY;
        [NMS(Index = 9)]
        /* 0x050 */ public float Zoom;
        [NMS(Index = 6)]
        /* 0x054 */ public NMSString0x200 Description;
        [NMS(Index = 5)]
        /* 0x254 */ public NMSString0x80 Filename;
        [NMS(Index = 4)]
        /* 0x2D4 */ public NMSString0x40 Name;
    }
}
