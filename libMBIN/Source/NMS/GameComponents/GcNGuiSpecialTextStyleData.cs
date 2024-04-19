using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3DE2EB0549638644, NameHash = 0x9C498422BDBE21FE)]
    public class GcNGuiSpecialTextStyleData : NMSTemplate
    {
        /* 0x00 */ public GcNGuiStyleAnimationData Animation;
        /* 0x18 */ public NMSString0x10 Name;
        /* 0x28 */ public List<NMSTemplate> StyleProperties;
    }
}
