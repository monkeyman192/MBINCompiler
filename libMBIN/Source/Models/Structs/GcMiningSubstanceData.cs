namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xC)]
    public class GcMiningSubstanceData : NMSTemplate
    {
        public GcRealitySubstanceCategory Category;
        public bool UseRarity;
        public GcRarity Rarity;
    }
}
