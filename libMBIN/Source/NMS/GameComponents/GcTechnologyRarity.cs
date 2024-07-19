namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x39B9A7A9078A0304, NameHash = 0xE4938804)]
    public class GcTechnologyRarity : NMSTemplate
    {
        // size: 0x7
        public enum TechnologyRarityEnum : uint {
            Normal,
            VeryCommon,
            Common,
            Rare,
            VeryRare,
            Impossible,
            Always,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public TechnologyRarityEnum TechnologyRarity;
    }
}
