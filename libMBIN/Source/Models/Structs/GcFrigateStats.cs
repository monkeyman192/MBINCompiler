namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x60)]
    public class GcFrigateStats : NMSTemplate
    {
        [NMS(Size = 0xA, EnumValue = new string[] { "Combat", "Exploration", "Mining", "Diplomatic", "FuelBurnRate", "FuelCapacity", "Speed", "ExtraLoot", "Repair", "Invulnerable" })]
        /* 0x00 */ public GcFrigateStatRange[] Stats;
        [NMS(Size = 0x10)]
        /* 0x50 */ public string InitialTrait;
    }
}
