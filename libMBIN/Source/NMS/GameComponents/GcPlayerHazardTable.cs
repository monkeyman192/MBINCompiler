using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAF1F6E61EC9275C5, NameHash = 0xCC978CCE3CFE915B)]
    public class GcPlayerHazardTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x0 */ public GcPlayerHazardData[] Table;
    }
}
