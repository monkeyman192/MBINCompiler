using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD8707477B1C561CA, NameHash = 0x733D7A989F8B9969)]
    public class GcCombatEffectsTable : NMSTemplate
    {
        public enum CombatEffectEnum { None, Fire, Stun, Slow }
        [NMS(Size = 0x4, EnumType = typeof(CombatEffectEnum))]
        /* 0x0 */ public GcCombatEffectData[] EffectsData;
    }
}
