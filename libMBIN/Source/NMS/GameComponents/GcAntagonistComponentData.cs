using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x118, GUID = 0x6FEF72C9EC5A8224, NameHash = 0xFAE78D5DE55087ED)]
    public class GcAntagonistComponentData : NMSTemplate
    {
        /* 0x00 */ public GcAntagonistGroup Group;
        /* 0x04 */ public float ScarinessFactor;
        /* 0x08 */ public float ShockedFactor;
        /* 0x0C */ public float ComprehensionFactor;
        /* 0x10 */ public float CommunicationDelay;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14 */ public byte[] Padding14;
        [NMS(Size = 0x5, EnumType = typeof(GcAntagonistGroup.AntagonistGroupEnum))]
        /* 0x18 */ public GcAntagonistFriend[] Friends;
        [NMS(Size = 0x5, EnumType = typeof(GcAntagonistGroup.AntagonistGroupEnum))]
        /* 0x90 */ public GcAntagonistEnemy[] Enemies;
        /* 0x108 */ public List<GcAntagonistPerception> Perceptions;
    }
}