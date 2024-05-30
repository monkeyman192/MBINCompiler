using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x6EE79AAE16322E43, NameHash = 0x6AA5D445686C3721)]
    public class TkProceduralTextureLayer : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 Group;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Name;
        [NMS(Index = 4)]
        /* 0x20 */ public List<TkProceduralTexture> Textures;
        [NMS(Index = 1)]
        /* 0x30 */ public float Probability;
        [NMS(Index = 3)]
        /* 0x34 */ public bool SelectToMatchBase;
    }
}
