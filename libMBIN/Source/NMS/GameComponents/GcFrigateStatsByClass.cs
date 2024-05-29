using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC2993FCF8C2A56C5, NameHash = 0x89CF360B576FF51D)]
    public class GcFrigateStatsByClass : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xA, EnumType = typeof(GcFrigateClass.FrigateClassEnum))]
        /* 0x0 */ public GcFrigateStats[] FrigateClass;
    }
}
