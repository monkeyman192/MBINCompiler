using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5CC730009F696C86, NameHash = 0xD755EBC8945CB867)]
    public class GcCombatEffectDamageMultiplier : NMSTemplate
    {
        /* 0x0 */ public GcCombatEffectType CombatEffectType;
        /* 0x4 */ public float DamageMultiplier;
    }
}
