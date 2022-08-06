using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7B9B198B34B0750A, NameHash = 0x6AA5D445686C3721)]
    public class TkProceduralTextureLayer : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public float Probability;
        /* 0x18 */ public NMSString0x10 Group;
        /* 0x28 */ public bool SelectToMatchBase;
        /* 0x30 */ public List<TkProceduralTexture> Textures;
    }
}
