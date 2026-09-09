using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x810C73FDD27A7C2F, NameHash = 0x1DEE0DCE)]
    public class GcSpacePoiEncounterTraderData : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x00 */ public Vector3f SpawnOffset;
        [NMS(Index = 7)]
        /* 0x10 */ public GcPlayerCommunicatorMessage HailingMessage;
        [NMS(Index = 0)]
        /* 0x60 */ public GcResourceElement CustomShipResource;
        [NMS(Index = 3)]
        /* 0xA8 */ public NMSString0x20A CustomHailOSD;
        [NMS(Index = 6)]
        /* 0xC8 */ public GcRealityCommonFactions ShipTrailFactionOverride;
        [NMS(Index = 8)]
        /* 0xCC */ public GcSpacePoiEncounterSpawnLocation SpawnLocation;
        [NMS(Index = 5)]
        /* 0xD0 */ public bool PersistHail;
        [NMS(Index = 2)]
        /* 0xD1 */ public bool UseCustomMessage;
        [NMS(Index = 1)]
        /* 0xD2 */ public bool UseSentinelCrashedShipResource;
        [NMS(Index = 4)]
        /* 0xD3 */ public bool WarpOutOnCombatStart;
    }
}
