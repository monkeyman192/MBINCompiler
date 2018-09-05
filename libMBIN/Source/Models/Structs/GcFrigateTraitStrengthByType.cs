namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x320)]
    public class GcFrigateTraitStrengthByType : NMSTemplate
    {
        [NMS(Size = 0xA, EnumValue = new string[] { "Combat", "Exploration", "Mining", "Diplomatic", "FuelBurnRate", "FuelCapacity", "Speed", "ExtraLoot", "Repair", "Invulnerable" })]

        public GcFrigateTraitStrengthValues[] FrigateStatType;
    }
}
