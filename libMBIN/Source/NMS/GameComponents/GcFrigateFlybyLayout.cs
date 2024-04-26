using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x254EA4B93755A17D, NameHash = 0xB1B9570C76B5EA49)]
    public class GcFrigateFlybyLayout : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public List<GcFrigateFlybyOption> Frigates;
        [NMS(Index = 0)]
        /* 0x10 */ public GcFrigateFlybyType FlybyType;
        [NMS(Index = 1)]
        /* 0x14 */ public float InitialSpeed;
        [NMS(Index = 4)]
        /* 0x18 */ public float InterestDistance;
        [NMS(Index = 3)]
        /* 0x1C */ public float InterestTime;
        [NMS(Index = 2)]
        /* 0x20 */ public float TargetSpeed;
    }
}
