using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x554D571AF17E7F25, NameHash = 0xD6BF3EB3)]
    public class GcNGuiSpecialTextStyles : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcNGuiSpecialTextStyleData> SpecialStyles;
    }
}
