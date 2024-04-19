using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x122643798D35042D, NameHash = 0x68C0F45A086C1EB)]
    public class GcDoShipEscort : NMSTemplate
    {
        /* 0x00 */ public GcRealityCommonFactions EscortTargetShipFaction;
        /* 0x04 */ public GcAISpaceshipRoles EscortTargetShipRole;
        /* 0x08 */ public GcAISpaceshipTypes EscortTargetShipType;
        /* 0x0C */ public float MaxSearchDistance;
        /* 0x10 */ public bool MatchFaction;
        /* 0x11 */ public bool MatchRole;
        /* 0x12 */ public bool MatchType;
    }
}
