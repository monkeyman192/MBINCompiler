namespace libMBIN.Models.Structs
{
    public class GcFrigateStatType : NMSTemplate
    {
        public int FrigateStatType;
        public string[] FrigateStatTypeValues()
        {
            return new[] { "Combat", "Exploration", "Mining", "Diplomatic", "FuelBurnRate", "FuelCapacity", "Speed", "ExtraLoot", "Repair", "Invulnerable" };
        }
    }
}
