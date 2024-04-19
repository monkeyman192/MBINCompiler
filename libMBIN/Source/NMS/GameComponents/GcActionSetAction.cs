using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA9E3A49F9DF82E9C, NameHash = 0xF69368BA4545C60E)]
    public class GcActionSetAction : NMSTemplate
    {
        /* 0x0 */ public GcInputActions Action;
        /* 0x4 */ public GcActionUseType Status;
    }
}
