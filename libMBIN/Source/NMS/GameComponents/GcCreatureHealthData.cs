using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x68, GUID = 0x9E936EDD82DCDD95, NameHash = 0x8554BC1ADD990AB6)]
    public class GcCreatureHealthData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 HurtAnim;
        /* 0x10 */ public NMSString0x10 DeathAnim;
        /* 0x20 */ public NMSString0x10 DeathEffect;
        /* 0x30 */ public NMSString0x10 HurtAudio;
        /* 0x40 */ public NMSString0x10 DeathAudio;
        /* 0x50 */ public bool DespawnOnDeath;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x51 */ public byte[] Padding51;
        /* 0x58 */ public List<NMSString0x20A> DespawnOnDeathDescriptors;
    }
}