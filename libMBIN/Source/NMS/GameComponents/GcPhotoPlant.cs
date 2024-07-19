namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAEC58C1CD705E809, NameHash = 0xC1358572)]
    public class GcPhotoPlant : NMSTemplate
    {
        // size: 0x3
        public enum PhotoPlantTypeEnum : uint {
            Sodium,
            Oxygen,
            BluePlant,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PhotoPlantTypeEnum PhotoPlantType;
    }
}
