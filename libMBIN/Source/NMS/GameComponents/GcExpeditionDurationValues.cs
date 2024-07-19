using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB62ADD01EBEC2640, NameHash = 0x9B04F25E)]
    public class GcExpeditionDurationValues : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5, EnumType = typeof(GcExpeditionDuration.ExpeditionDurationEnum))]
        /* 0x0 */ public int[] Duration;
    }
}
