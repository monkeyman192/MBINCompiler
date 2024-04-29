using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x49A73B7296D1026A, NameHash = 0xFF1B80B6AD49D2A3)]
    public class GcAntagonistEnemy : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<NMSString0x10> Perceptions;
        [NMS(Index = 1)]
        /* 0x10 */ public float GrudgeFactor;
        [NMS(Index = 0)]
        /* 0x14 */ public float HatredFactor;
    }
}
