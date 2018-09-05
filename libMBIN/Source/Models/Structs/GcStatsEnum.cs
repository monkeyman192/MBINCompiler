namespace libMBIN.Models.Structs
{
    public class GcStatsEnum : NMSTemplate     // size: 0x4
    {
        public int Stat;
        public string[] StatValues()
        {
            return new[]
            {
                "None", "DEPOTS_BROKEN", "FPODS_BROKEN", "PLANTS_PLANTED", "SALVAGE_LOOTED", "TREASURE_FOUND", "QUADS_KILLED", "WALKERS_KILLED"
            };
        }
    }
}
