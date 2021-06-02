using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x40, GUID = 0x8B41C2636D306EC3, NameHash = 0x5DBD3B5170282610)]
    public class TkControllerSpecification : NMSTemplate
    {
        public NMSString0x10 Id;
        public TkButtonImageLookup ImageLookup;
        public TkAxisImageLookup AxisImageLookup;
        public TkChordsImageLookup ChordsImageLookup;
    }
}
