using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xA461FF4AF64E4012, NameHash = 0x39B4070AE5C76F6F)]
    public class GcAntagonistGroup : NMSTemplate
    {
        // size: 0x6
        public enum AntagonistGroupEnum { Player, Fiends, Creatures, Sentinels, Turrets, Walls }
        /* 0x0 */ public AntagonistGroupEnum AntagonistGroup;
    }
}