using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4E13F4B403F32470, NameHash = 0x799BCCB536A8AD49)]
    public class GcPhotoBuildings : NMSTemplate
    {
        public int AmountMin;
        public int AmountMax;
        public GcPhotoBuilding BuildingType;
    }
}
