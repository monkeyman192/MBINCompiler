using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD791AAADC39FC515, NameHash = 0x64527D52)]
    public class GcDoShipEscort : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public GcRealityCommonFactions EscortTargetShipFaction;
        [NMS(Index = 1)]
        /* 0x04 */ public GcAISpaceshipRoles EscortTargetShipRole;
        [NMS(Index = 5)]
        /* 0x08 */ public GcAISpaceshipTypes EscortTargetShipType;
        [NMS(Index = 6)]
        /* 0x0C */ public float MaxSearchDistance;
        [NMS(Index = 2)]
        /* 0x10 */ public bool MatchFaction;
        [NMS(Index = 0)]
        /* 0x11 */ public bool MatchRole;
        [NMS(Index = 4)]
        /* 0x12 */ public bool MatchType;
    }
}
