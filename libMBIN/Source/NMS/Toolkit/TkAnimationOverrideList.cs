using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x343EDA804605FF26, NameHash = 0x16DFD5A1)]
    public class TkAnimationOverrideList : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<TkAnimationData> Anims;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Name;
    }
}
