using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xF6CEE6EA5A526B2F, NameHash = 0x39B4070AE5C76F6F)]
    public class GcAntagonistGroup : NMSTemplate
    {
        // Size: 0x5
        public enum AntagonistGroupEnum { Player, Fiends, Creatures, Sentinels, Turrets }
        /* 0x0 */ public AntagonistGroupEnum AntagonistGroup;
    }
}