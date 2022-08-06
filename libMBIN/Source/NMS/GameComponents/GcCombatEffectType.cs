using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x072FD0C82E70B688, NameHash = 0x0CC36FE8AD202DF8)]
    public class GcCombatEffectType : NMSTemplate
    {
        // size: 0x4
        public enum CombatEffectTypeEnum { None, Fire, Stun, Slow }
        /* 0x0 */ public CombatEffectTypeEnum CombatEffectType;
    }
}
