using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4E7BAD2A3814D5E3, NameHash = 0x5525EF02)]
    public class GcFrigateStatsByClass : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xA, EnumType = typeof(GcFrigateClass.FrigateClassEnum))]
        /* 0x0 */ public GcFrigateStats[] FrigateClass;
    }
}
