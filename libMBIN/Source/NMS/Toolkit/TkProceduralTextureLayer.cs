using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x40, GUID = 0xBD83E215E5C89AE7, NameHash = 0x6AA5D445686C3721)]
    public class TkProceduralTextureLayer : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;

        /* 0x10 */ public float Probability;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14 */ public byte[] Padding14;

        /* 0x18 */ public NMSString0x10 Group;

        /* 0x28 */ public bool SelectToMatchBase;
        /* 0x30 */ public List<TkProceduralTexture> Textures;
    }
}
