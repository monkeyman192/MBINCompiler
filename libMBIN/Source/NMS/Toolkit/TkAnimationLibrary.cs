using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x34AF6232C5D4D342, NameHash = 0x32970C1B)]
    public class TkAnimationLibrary : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<TkAnimationData> Anims;
        [NMS(Index = 1)]
        /* 0x10 */ public List<TkAnimationOverrideList> Overrides;
        [NMS(Index = 2)]
        /* 0x20 */ public TkBlendTreeLibrary Trees;
    }
}
