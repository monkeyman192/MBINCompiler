using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4D86CADD1E49AD2)]
    public class GcInventoryClassProbabilities : NMSTemplate
    {
        [NMS( EnumType = typeof( GcInventoryClass.InventoryClassEnum ) )]
        public float[] ClassProbabilities;
    }
}
