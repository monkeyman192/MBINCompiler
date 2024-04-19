using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD3C5FD5ACDF2D4F6, NameHash = 0x8554BC1ADD990AB6)]
    public class GcCreatureHealthData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 DeathAnim;
        /* 0x10 */ public NMSString0x10 DeathAudio;
        /* 0x20 */ public NMSString0x10 DeathEffect;
        /* 0x30 */ public List<NMSString0x20A> DespawnOnDeathDescriptors;
        /* 0x40 */ public NMSString0x10 HurtAnim;
        /* 0x50 */ public NMSString0x10 HurtAudio;
        /* 0x60 */ public bool DespawnOnDeath;
    }
}
