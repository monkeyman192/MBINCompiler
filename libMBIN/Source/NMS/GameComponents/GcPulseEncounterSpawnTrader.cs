using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6DE78C0B6D361348, NameHash = 0x8C01FB7E)]
    public class GcPulseEncounterSpawnTrader : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public GcPlayerCommunicatorMessage HailingMessage;
        [NMS(Index = 0)]
        /* 0x50 */ public GcResourceElement CustomShipResource;
        [NMS(Index = 3)]
        /* 0x98 */ public NMSString0x20A CustomHailOSD;
        [NMS(Index = 5)]
        /* 0xB8 */ public GcRealityCommonFactions ShipTrailFactionOverride;
        [NMS(Index = 2)]
        /* 0xBC */ public bool UseCustomMessage;
        [NMS(Index = 1)]
        /* 0xBD */ public bool UseSentinelCrashedShipResource;
        [NMS(Index = 4)]
        /* 0xBE */ public bool WarpOutOnCombatStart;
    }
}
