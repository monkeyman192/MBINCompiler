using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x129E3D90299A62EC, NameHash = 0xDC105ACA)]
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
