using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3A0BF0289E367365, NameHash = 0xCF6D9992)]
    public class TkAnimationNotifies : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkAnimationNotify> Notifies;
    }
}
