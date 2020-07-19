using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x71CAAD93EF1D64EC, NameHash = 0xFF1B80B6AD49D2A3)]
    public class GcAntagonistEnemy : NMSTemplate
    {
        /* 0x0 */ public float HatredFactor;
        /* 0x4 */ public float GrudgeFactor;
        /* 0x8 */ public List<NMSString0x10> Perceptions;
    }
}