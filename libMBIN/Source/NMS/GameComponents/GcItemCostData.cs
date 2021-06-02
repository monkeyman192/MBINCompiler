using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x4CE334B92351578B, NameHash = 0xA3976E1971095FC4)]
    public class GcItemCostData : NMSTemplate
    {
        public NMSString0x10 ID;
        public float Cost;
        public float MinCost;
        public float MaxCost;
        public float ChangePerSale;
    }
}