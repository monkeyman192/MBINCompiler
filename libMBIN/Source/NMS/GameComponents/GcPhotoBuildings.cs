using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE1AD4AB1D45B5EFC, NameHash = 0x799BCCB536A8AD49)]
    public class GcPhotoBuildings : NMSTemplate
    {
        /* 0x0 */ public int AmountMax;
        /* 0x4 */ public int AmountMin;
        /* 0x8 */ public GcPhotoBuilding BuildingType;
    }
}
