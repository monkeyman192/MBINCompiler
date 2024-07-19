using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x227A91478037740A, NameHash = 0x802FDBDE)]
    public class TkAnimMask : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Id;
        [NMS(Index = 1)]
        /* 0x20 */ public List<TkAnimMaskBone> Bones;
    }
}
