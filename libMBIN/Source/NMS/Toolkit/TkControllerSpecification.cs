using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x40, GUID = 0x1830AC570F5CC6A2, NameHash = 0x5DBD3B5170282610)]
    public class TkControllerSpecification : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public TkButtonImageLookup ImageLookup;
        public TkAxisImageLookup AxisImageLookup;
        public TkChordsImageLookup ChordsImageLookup;
    }
}
