using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x50538964135E2380)]
    public class GcInventoryClassCostMultiplier : NMSTemplate
    {
        [NMS( EnumType = typeof( GcInventoryClass.InventoryClassEnum ) )]
        public float[] Multiplier;
    }
}
