using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA3C70469328512D8, NameHash = 0xCC7E718A)]
    public class GcMissionConditionPlanetResourceHint : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A UseScanEventToDetermineLocalResource;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 ResourceHint;
        [NMS(Index = 2)]
        /* 0x30 */ public GcLocalSubstanceType LocalSubstanceType;
        [NMS(Index = 3)]
        /* 0x34 */ public bool AllowInShip;
        [NMS(Index = 4)]
        /* 0x35 */ public bool TestAllPlanetsInSystem;
    }
}
