using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x94AC076DB1249E22, NameHash = 0x314960F4DFCC0B34)]
    public class GcPlanetaryMappingValues : NMSTemplate
    {
        /* 0x0 */ public GcPlanetSize PlanetSize;
        /* 0x4 */ public ushort PolesPerSection;
        /* 0x6 */ public ushort SectionPerSide;
    }
}
