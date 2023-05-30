using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcResourceElement : NMSTemplate // size = 0x2A8
    {
        public NMSString0x80 Filename;
        [NMS(Ignore = true)]
        public long EmptyNode1;
        public GcSeed GenerationSeed;
        public NMSString0x200 AltId;
        public TkProceduralTextureChosenOptionList Texture;
    }
}
