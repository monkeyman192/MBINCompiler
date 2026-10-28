using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDCBD0D66A3F421BA, NameHash = 0x25517A76)]
    public class GcInputActionInfoMap : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x130, EnumType = typeof(GcInputActions.InputActionEnum))]
        /* 0x0 */ public GcInputActionInfo[] ActionMap;
    }
}
