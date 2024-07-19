using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x64CC3953232F6C8, NameHash = 0xEE278077)]
    public class GcActionSetAction : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcInputActions Action;
        [NMS(Index = 0)]
        /* 0x4 */ public GcActionUseType Status;
    }
}
