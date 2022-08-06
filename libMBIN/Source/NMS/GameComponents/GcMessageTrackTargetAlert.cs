using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDB104196CBE2503A, NameHash = 0xACD740CC9B208196)]
    public class GcMessageTrackTargetAlert : NMSTemplate
    {
        /* 0x00 */ public int Attacker;
        /* 0x04 */ public int Victim;
        /* 0x10 */ public Vector3f AlertPos;
        /* 0x20 */ public bool Primary;
    }
}
