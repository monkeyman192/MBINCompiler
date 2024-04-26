namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7AFDCAB459BF6B79, NameHash = 0x5FD144DDEE5E5ECF)]
    public class GcCreatureRarity : NMSTemplate
    {
        // size: 0x4
        public enum CreatureRarityEnum : uint {
            Common,
            Uncommon,
            Rare,
            SuperRare,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CreatureRarityEnum CreatureRarity;
    }
}
