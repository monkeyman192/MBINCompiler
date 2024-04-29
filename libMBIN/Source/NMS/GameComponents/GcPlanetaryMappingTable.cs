using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5FA61990C99C1597, NameHash = 0xB47263D5F2CB7D5D)]
    public class GcPlanetaryMappingTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x4)]
        /* 0x0 */ public GcPlanetaryMappingValues[] MappingInfo;
    }
}
