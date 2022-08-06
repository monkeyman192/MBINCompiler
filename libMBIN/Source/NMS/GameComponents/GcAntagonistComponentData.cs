using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x51B376CBC0E11C67, NameHash = 0xFAE78D5DE55087ED)]
    public class GcAntagonistComponentData : NMSTemplate
    {
        /* 0x000 */ public GcAntagonistGroup Group;
        /* 0x004 */ public float ScarinessFactor;
        /* 0x008 */ public float ShockedFactor;
        /* 0x00C */ public float ComprehensionFactor;
        /* 0x010 */ public float CommunicationDelay;
        [NMS(Size = 0x6, EnumType = typeof(GcAntagonistGroup.AntagonistGroupEnum))]
        /* 0x018 */ public GcAntagonistFriend[] Friends;
        [NMS(Size = 0x6, EnumType = typeof(GcAntagonistGroup.AntagonistGroupEnum))]
        /* 0x0A8 */ public GcAntagonistEnemy[] Enemies;
        /* 0x138 */ public List<GcAntagonistPerception> Perceptions;
    }
}
