using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4CE334B92351578B, NameHash = 0xA3976E1971095FC4)]
    public class GcItemCostData : NMSTemplate        // size: 0x20
    {
        [NMS(Size = 0x10)]
        public string ID;
        public float Cost;
        public float MinCost;
        public float MaxCost;
        public float ChangePerSale;
    }
}
