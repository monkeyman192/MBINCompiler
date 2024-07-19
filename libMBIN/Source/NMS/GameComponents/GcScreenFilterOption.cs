using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC6B12DEBAE4C2801, NameHash = 0x4F0CAB14)]
    public class GcScreenFilterOption : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcScreenFilters Filter;
        [NMS(Index = 1)]
        /* 0x4 */ public float Weight;
    }
}
