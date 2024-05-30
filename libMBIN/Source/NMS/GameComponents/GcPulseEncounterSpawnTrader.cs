using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x59CD69094DFF5A12, NameHash = 0x61E014828AD14CD)]
    public class GcPulseEncounterSpawnTrader : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcResourceElement CustomShipResource;
        [NMS(Index = 6)]
        /* 0x2A8 */ public GcPlayerCommunicatorMessage HailingMessage;
        [NMS(Index = 3)]
        /* 0x2F8 */ public NMSString0x20A CustomHailOSD;
        [NMS(Index = 5)]
        /* 0x318 */ public GcRealityCommonFactions ShipTrailFactionOverride;
        [NMS(Index = 2)]
        /* 0x31C */ public bool UseCustomMessage;
        [NMS(Index = 1)]
        /* 0x31D */ public bool UseSystemSeedForResource;
        [NMS(Index = 4)]
        /* 0x31E */ public bool WarpOutOnCombatStart;
    }
}
