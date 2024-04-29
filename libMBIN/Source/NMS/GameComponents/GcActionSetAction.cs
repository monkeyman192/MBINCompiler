using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x65B4F18480D25725, NameHash = 0xF69368BA4545C60E)]
    public class GcActionSetAction : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcInputActions Action;
        [NMS(Index = 0)]
        /* 0x4 */ public GcActionUseType Status;
    }
}
