using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFF5CA38F118A0405, NameHash = 0x9E60066285AC5880)]
    public class GcNGuiSpecialTextStyles : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcNGuiSpecialTextStyleData> SpecialStyles;
    }
}
