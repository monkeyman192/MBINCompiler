using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8C117B9B0F41AC5E, NameHash = 0xEE278077)]
    public class GcActionSetAction : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcInputActions Action;
        [NMS(Index = 0)]
        /* 0x4 */ public GcActionUseType Status;
    }
}
