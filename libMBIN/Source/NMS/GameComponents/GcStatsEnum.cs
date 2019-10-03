using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF15A2E173DF0EFCA, NameHash = 0xACDE6E8DA19EC2E2)]
    public class GcStatsEnum : NMSTemplate
    {
        // 0xB entries
		public enum StatEnum { None, DEPOTS_BROKEN, FPODS_BROKEN, PLANTS_PLANTED, SALVAGE_LOOTED, TREASURE_FOUND, QUADS_KILLED, WALKERS_KILLED, FLORA_KILLED, PLANTS_GATHERED, BONES_FOUND }
		public StatEnum Stat;
    }
}
