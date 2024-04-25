using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7B72840E499CFC41, NameHash = 0x203F104657EA616)]
    public class GcPulseEncounterSpawnSpaceHostiles : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcResourceElement CustomShipResource;
        [NMS(Index = 2)]
        /* 0x2A8 */ public NMSString0x10 AttackDefinition;
        [NMS(Index = 1)]
        /* 0x2B8 */ public int NumberOfShips;
    }
}
