using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCBE1685FBF011336, NameHash = 0xC47EFA1C)]
    public class GcCreatureHealthData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 DeathAnim;
        [NMS(Index = 4)]
        /* 0x10 */ public NMSString0x10 DeathAudio;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x10 DeathEffect;
        [NMS(Index = 6)]
        /* 0x30 */ public List<NMSString0x20A> DespawnOnDeathDescriptors;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x10 HurtAnim;
        [NMS(Index = 3)]
        /* 0x50 */ public NMSString0x10 HurtAudio;
        [NMS(Index = 5)]
        /* 0x60 */ public bool DespawnOnDeath;
    }
}
