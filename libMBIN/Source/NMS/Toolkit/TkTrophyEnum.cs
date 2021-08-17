using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x4, GUID = 0x53ACC709803EED2D, NameHash = 0xF50D34444AC02C1E)]
    public class TkTrophyEnum : NMSTemplate
    {
        // size: 0x6
        public enum TrophyEnum { None, Trophy0, Trophy1, Trophy2, Trophy3, Trophy4 }
        /* 0x0 */ public TrophyEnum Trophy;
    }
}
