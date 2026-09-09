using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1C9C5673E0B37623, NameHash = 0x16DFD5A1)]
    public class TkAnimationOverrideList : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<TkAnimationData> Anims;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Name;
    }
}
