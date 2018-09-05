namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x8)]
    public class GcPhotoBuildings : NMSTemplate
    {
        public short AmountMin;
        public short AmountMax;
        public GcPhotoBuilding BuildingType;
    }
}
