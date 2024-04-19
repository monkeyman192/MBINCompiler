using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA07D0ED3E999FF7F, NameHash = 0x61E014828AD14CD)]
    public class GcPulseEncounterSpawnTrader : NMSTemplate
    {
        /* 0x000 */ public GcResourceElement CustomShipResource;
        /* 0x2A8 */ public GcPlayerCommunicatorMessage HailingMessage;
        /* 0x2F8 */ public NMSString0x20A CustomHailOSD;
        /* 0x318 */ public GcRealityCommonFactions ShipTrailFactionOverride;
        /* 0x31C */ public bool UseCustomMessage;
        /* 0x31D */ public bool UseSystemSeedForResource;
        /* 0x31E */ public bool WarpOutOnCombatStart;
    }
}
