using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x928A4B646DF06D90, NameHash = 0x9CECF7C2)]
    public class GcPhotoBuildings : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int AmountMax;
        [NMS(Index = 0)]
        /* 0x4 */ public int AmountMin;
        [NMS(Index = 2)]
        /* 0x8 */ public GcPhotoBuilding BuildingType;
    }
}
