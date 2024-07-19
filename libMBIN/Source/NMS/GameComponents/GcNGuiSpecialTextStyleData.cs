using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x918BC6BEF259B92B, NameHash = 0x2B45DEDD)]
    public class GcNGuiSpecialTextStyleData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcNGuiStyleAnimationData Animation;
        [NMS(Index = 0)]
        /* 0x18 */ public NMSString0x10 Name;
        [NMS(Index = 1)]
        /* 0x28 */ public List<NMSTemplate> StyleProperties;
    }
}
