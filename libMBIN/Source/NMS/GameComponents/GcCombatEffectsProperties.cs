using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8AAA1550E1C281E5, NameHash = 0xC39E8583E846A389)]
    public class GcCombatEffectsProperties : NMSTemplate
    {
        /* 0x0 */ public bool IsAffected;
        /* 0x1 */ public bool IgnoreFromOtherPlayers;
        /* 0x2 */ public bool IgnoreFromSelf;
        /* 0x4 */ public float DurationMultiplier;
        /* 0x8 */ public float DamageMultiplier;
    }
}
