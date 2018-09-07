namespace libMBIN.Models.Structs
{
    public class GcFrigateStatType : NMSTemplate
    {
		public enum FrigateStatTypeEnum { Combat, Exploration, Mining, Diplomatic, FuelBurnRate, FuelCapacity, Speed, ExtraLoot, Repair, Invulnerable }
		public FrigateStatTypeEnum FrigateStatType;
    }
}
