using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0x8CA5C95D23D1A184, NameHash = 0x38D56749327FCFE6)]
    public class GcAreaDamageData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public float Radius;
        /* 0x14 */ public float DelayPerMetre;
        /* 0x18 */ public NMSString0x10 PlayerDamageId;
        /* 0x28 */ public float Damage;
        /* 0x2C */ public bool InstantKill;
        /* 0x2D */ public bool DamagePlayers;
        /* 0x2E */ public bool DamageCreatures;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x2F */ public byte[] EndPadding;
    }
}
