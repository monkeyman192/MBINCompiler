using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB4F5A3CBC47938A4, NameHash = 0xFAE78D5DE55087ED)]
    public class GcAntagonistComponentData : NMSTemplate
    {
        [NMS(Size = 0x6, EnumType = typeof(GcAntagonistGroup.AntagonistGroupEnum))]
        /* 0x000 */ public GcAntagonistEnemy[] Enemies;
        [NMS(Size = 0x6, EnumType = typeof(GcAntagonistGroup.AntagonistGroupEnum))]
        /* 0x090 */ public GcAntagonistFriend[] Friends;
        /* 0x120 */ public List<GcAntagonistPerception> Perceptions;
        /* 0x130 */ public float CommunicationDelay;
        /* 0x134 */ public float ComprehensionFactor;
        /* 0x138 */ public GcAntagonistGroup Group;
        /* 0x13C */ public float ScarinessFactor;
        /* 0x140 */ public float ShockedFactor;
    }
}
