using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x78F9D845E2259A5F, NameHash = 0xBEAB285DC115E7C6)]
    public class GcInputActionInfoMap : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x126, EnumType = typeof(GcInputActions.InputActionEnum))]
        /* 0x0 */ public GcInputActionInfo[] ActionMap;
    }
}
