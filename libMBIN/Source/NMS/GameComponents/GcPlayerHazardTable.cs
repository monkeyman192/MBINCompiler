using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDDD00D48E4ECED82, NameHash = 0xA6C1713F)]
    public class GcPlayerHazardTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x0 */ public GcPlayerHazardData[] Table;
    }
}
