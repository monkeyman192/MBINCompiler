namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x500)]
    public class GcFrigateTraitIcons : NMSTemplate
    {
        [NMS(Size = 0xA, EnumValue = new string[] { "Combat", "Exploration", "Mining", "Diplomatic", "FuelBurnRate", "FuelCapacity", "Speed", "ExtraLoot", "Repair", "Invulnerable" })]

        public NMSString0x80[] Icons;
    }
}
