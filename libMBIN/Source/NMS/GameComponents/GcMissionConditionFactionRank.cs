using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x33B33BA12BA1006B, NameHash = 0x986E86EA3EB2C57C)]
    public class GcMissionConditionFactionRank : NMSTemplate
    {
        public GcMissionFaction Faction;
        public bool UseSystemRace;
        public int Rank;
    }
}
