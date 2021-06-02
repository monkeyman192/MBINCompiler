using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x200, GUID = 0x88ACCDCEEABFEB00, NameHash = 0x1C7FB8C61B710244)]
    public class GcIkPistonData : NMSTemplate
    {
        public NMSString0x100 Joint1Name;
        public NMSString0x100 Joint2Name;
    }
}
