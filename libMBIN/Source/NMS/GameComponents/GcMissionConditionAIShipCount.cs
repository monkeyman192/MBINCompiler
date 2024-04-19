using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE09E786120C0434, NameHash = 0xC1D7229530508055)]
    public class GcMissionConditionAIShipCount : NMSTemplate
    {
        /* 0x0 */ public int Count;
        /* 0x4 */ public TkEqualityEnum Test;
        /* 0x8 */ public GcRealityCommonFactions Type;
    }
}
