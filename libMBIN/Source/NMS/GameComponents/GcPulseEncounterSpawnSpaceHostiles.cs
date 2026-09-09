using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x53A034D37E99B21D, NameHash = 0x2BCBA264)]
    public class GcPulseEncounterSpawnSpaceHostiles : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcResourceElement CustomShipResource;
        [NMS(Index = 2)]
        /* 0x48 */ public NMSString0x10 AttackDefinition;
        [NMS(Index = 1)]
        /* 0x58 */ public int NumberOfShips;
    }
}
