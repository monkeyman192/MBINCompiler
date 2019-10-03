using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8231FB8008556170, NameHash = 0x9E60066285AC5880)]
    public class GcNGuiSpecialTextStyles : NMSTemplate
    {
        public List<GcNGuiSpecialTextStyleData> SpecialStyles;
    }
}
