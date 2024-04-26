namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E5033B6253D925C, NameHash = 0x85BD8B90D73C1D42)]
    public class GcRarity : NMSTemplate
    {
        // size: 0x3
        public enum RarityEnum : uint {
            Common,
            Uncommon,
            Rare,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public RarityEnum Rarity;
    }
}
