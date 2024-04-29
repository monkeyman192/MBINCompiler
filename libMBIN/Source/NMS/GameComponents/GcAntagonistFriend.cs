using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x95FEEBE6C1044D48, NameHash = 0xFA881469CD77285D)]
    public class GcAntagonistFriend : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSString0x10> Perceptions;
        [NMS(Index = 0)]
        /* 0x10 */ public float ArticulationFactor;
    }
}
