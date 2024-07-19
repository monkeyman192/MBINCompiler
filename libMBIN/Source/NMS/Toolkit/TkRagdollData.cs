using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2518A3FA6F16248D, NameHash = 0xAA0A463F)]
    public class TkRagdollData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<NMSString0x20> ChainEnds;
        [NMS(Index = 1)]
        /* 0x10 */ public List<NMSString0x20> ExcludeJoints;
    }
}
