using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC599820543A8A124, NameHash = 0x43CC1E86)]
    public class GcDeliverableComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcDeliverableType DeliveryType;
    }
}
