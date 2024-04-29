using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3978F42263F45BAF, NameHash = 0x89CF360B576FF51D)]
    public class GcFrigateStatsByClass : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x9, EnumType = typeof(GcFrigateClass.FrigateClassEnum))]
        /* 0x0 */ public GcFrigateStats[] FrigateClass;
    }
}
