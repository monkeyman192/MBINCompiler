using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD1752B2A47080504, NameHash = 0x9E60066285AC5880)]
    public class GcNGuiSpecialTextStyles : NMSTemplate
    {
        public List<GcNGuiSpecialTextStyleData> SpecialStyles;
    }
}