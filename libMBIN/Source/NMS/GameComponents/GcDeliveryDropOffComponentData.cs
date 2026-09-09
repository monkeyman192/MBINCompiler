using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x63EFA15746357CA6, NameHash = 0x64DE2F4B)]
    public class GcDeliveryDropOffComponentData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5, EnumType = typeof(GcDeliverableType.DeliverableTypeEnum))]
        /* 0x0 */ public GcDeliverableReward[] DeliveryReward;
    }
}
