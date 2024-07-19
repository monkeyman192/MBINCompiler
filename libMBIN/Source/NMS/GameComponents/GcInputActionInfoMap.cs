using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x83DBF775EC3EB0D3, NameHash = 0x25517A76)]
    public class GcInputActionInfoMap : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x122, EnumType = typeof(GcInputActions.InputActionEnum))]
        /* 0x0 */ public GcInputActionInfo[] ActionMap;
    }
}
