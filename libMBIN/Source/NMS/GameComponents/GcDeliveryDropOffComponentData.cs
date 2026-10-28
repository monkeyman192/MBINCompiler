using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4F520595D53FA6EC, NameHash = 0x64DE2F4B)]
    public class GcDeliveryDropOffComponentData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5, EnumType = typeof(GcDeliverableType.DeliverableTypeEnum))]
        /* 0x00 */ public GcDeliverableReward[] DeliveryReward;
        [NMS(Index = 1)]
        /* 0x50 */ public List<NMSString0x10> ValidMissionIds;
        [NMS(Index = 2)]
        /* 0x60 */ public float RejectEjectDelay;
        [NMS(Index = 3)]
        /* 0x64 */ public float RejectEjectDistance;
        [NMS(Index = 4)]
        /* 0x68 */ public float RejectEjectHeight;
        [NMS(Index = 5)]
        /* 0x6C */ public float RejectEjectLift;
        [NMS(Index = 6)]
        /* 0x70 */ public float RejectEjectTime;
        [NMS(Index = 7)]
        /* 0x74 */ public TkCurveType RejectEjectCurve;
    }
}
