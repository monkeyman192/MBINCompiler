using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4C15A6F0B63EEF90, NameHash = 0x52912F535A46A50C)]
    public class TkRagdollData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<NMSString0x20> ChainEnds;
        [NMS(Index = 3)]
        /* 0x10 */ public List<NMSString0x20> ExcludeJoints;
        [NMS(Index = 0)]
        /* 0x20 */ public float Density;
        [NMS(Index = 1)]
        /* 0x24 */ public float Gravity;
    }
}
