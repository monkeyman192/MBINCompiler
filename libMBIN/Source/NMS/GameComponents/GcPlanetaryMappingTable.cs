using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7C3BE100297EEDDD, NameHash = 0xA6915D9C)]
    public class GcPlanetaryMappingTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x4)]
        /* 0x0 */ public GcPlanetaryMappingValues[] MappingInfo;
    }
}
