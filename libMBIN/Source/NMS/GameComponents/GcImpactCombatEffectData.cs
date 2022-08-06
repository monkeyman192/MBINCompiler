using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x039E03F7CE8F8A08, NameHash = 0x3213D59A0301372C)]
    public class GcImpactCombatEffectData : NMSTemplate
    {
        // size: 0x4
        public enum CombatEffectTypeEnum { None, Fire, Stun, Slow }
        /* 0x0 */ public CombatEffectTypeEnum CombatEffectType;
        /* 0x4 */ public float TotalDuration;
        /* 0x8 */ public float DamagePerSeccond;
        /* 0xC */ public float CurrentDuration;
    }
}
