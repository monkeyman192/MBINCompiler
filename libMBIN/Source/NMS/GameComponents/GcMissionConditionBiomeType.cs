using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x12C3370677326733, NameHash = 0xFD18D350)]
    public class GcMissionConditionBiomeType : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcBiomeType Type;
        [NMS(Index = 1)]
        /* 0x4 */ public bool AnyInfested;
    }
}
