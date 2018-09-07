namespace libMBIN.Models.Structs
{
    public class GcStatsEnum : NMSTemplate     // size: 0x4
    {
		public enum StatEnum { None, DEPOTS_BROKEN, FPODS_BROKEN, PLANTS_PLANTED, SALVAGE_LOOTED, TREASURE_FOUND, QUADS_KILLED, WALKERS_KILLED }
		public StatEnum Stat;
    }
}
