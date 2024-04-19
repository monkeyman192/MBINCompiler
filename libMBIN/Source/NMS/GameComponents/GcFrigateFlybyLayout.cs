using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x254EA4B93755A17D, NameHash = 0xB1B9570C76B5EA49)]
    public class GcFrigateFlybyLayout : NMSTemplate
    {
        /* 0x00 */ public List<GcFrigateFlybyOption> Frigates;
        /* 0x10 */ public GcFrigateFlybyType FlybyType;
        /* 0x14 */ public float InitialSpeed;
        /* 0x18 */ public float InterestDistance;
        /* 0x1C */ public float InterestTime;
        /* 0x20 */ public float TargetSpeed;
    }
}
