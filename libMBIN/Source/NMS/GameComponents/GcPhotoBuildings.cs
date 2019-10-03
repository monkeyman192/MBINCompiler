using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0x2659C9C28DF6AFB3, NameHash = 0x799BCCB536A8AD49)]
    public class GcPhotoBuildings : NMSTemplate
    {
        public int AmountMin;
        public int AmountMax;
        public GcPhotoBuilding BuildingType;
    }
}
