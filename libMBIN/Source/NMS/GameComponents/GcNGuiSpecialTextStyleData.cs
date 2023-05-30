using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcNGuiSpecialTextStyleData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public List<NMSTemplate> StyleProperties;
        /* 0x20 */ public GcNGuiStyleAnimationData Animation;
    }
}
