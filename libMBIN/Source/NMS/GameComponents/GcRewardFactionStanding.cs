using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents {
	[NMS(GUID = 0x8063288CE90A48D3, NameHash = 0x8B79DF642602985A)]
    public class GcRewardFactionStanding : NMSTemplate
    {
        public GcMissionFaction Faction;
        public int AmountMin;
        public int AmountMax;
    }
}
