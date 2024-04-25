namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB76E0C8D3E433192, NameHash = 0x1D300E2AA74F7BA7)]
    public class GcMissionFaction : NMSTemplate
    {
        // size: 0xA
        public enum MissionFactionEnum : uint {
            Gek,
            Korvax,
            Vykeen,
            TradeGuild,
            WarriorGuild,
            ExplorerGuild,
            Nexus,
            Pirates,
            Builders,
            None,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public MissionFactionEnum MissionFaction;
    }
}
