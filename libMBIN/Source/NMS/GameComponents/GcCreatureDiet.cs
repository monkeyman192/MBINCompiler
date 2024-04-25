namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD8BBB83FF622C3C4, NameHash = 0xEF306B43D1C79D7F)]
    public class GcCreatureDiet : NMSTemplate
    {
        // size: 0x4
        public enum DietEnum : uint {
            Carnivore,
            Omnivore,
            Herbivore,
            Robot,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DietEnum Diet;
    }
}
