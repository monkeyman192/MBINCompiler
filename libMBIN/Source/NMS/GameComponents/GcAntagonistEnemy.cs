using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5A770BA39A994ADD, NameHash = 0xFF1B80B6AD49D2A3)]
    public class GcAntagonistEnemy : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> Perceptions;
        /* 0x10 */ public float GrudgeFactor;
        /* 0x14 */ public float HatredFactor;
    }
}
