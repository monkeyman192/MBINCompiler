using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5850C30F2E046A4, NameHash = 0xD8FBEE24)]
    public class GcMissionConditionAIShipCount : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int Count;
        [NMS(Index = 2)]
        /* 0x4 */ public TkEqualityEnum Test;
        [NMS(Index = 0)]
        /* 0x8 */ public GcRealityCommonFactions Type;
    }
}
