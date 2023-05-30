using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkProceduralTextureLayer : NMSTemplate
    {
        public NMSString0x10 Name;

        public float Probability;
        public int Unknown14;

        public NMSString0x10 Group;

        public bool SelectToMatchBase;
        public List<TkProceduralTexture> Textures;
    }
}
