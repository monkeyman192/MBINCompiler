using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x3235EA918856F2FB, NameHash = 0x6AA5D445686C3721)]
    public class TkProceduralTextureLayer : NMSTemplate     // size: 0x40
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Name;

        /* 0x10 */ public float Probability;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14 */ public byte[] Padding14;

        [NMS(Size = 0x10)]
        /* 0x18 */ public string Group;

        /* 0x28 */ public bool SelectToMatchBase;
        /* 0x30 */ public List<TkProceduralTexture> Textures;
    }
}
