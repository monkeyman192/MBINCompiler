using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE5815898D246FAA8, NameHash = 0x35BF34FE4907C4BC)]
    public class GcMissionConditionBiomeType : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcBiomeType Type;
        [NMS(Index = 1)]
        /* 0x4 */ public bool AnyInfested;
    }
}
