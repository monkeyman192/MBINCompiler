using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC2707513CCBE73B4, NameHash = 0x5CAB593E)]
    public class GcAntagonistComponentData : NMSTemplate
    {
        [NMS(Index = 6, Size = 0x6, EnumType = typeof(GcAntagonistGroup.AntagonistGroupEnum))]
        /* 0x000 */ public GcAntagonistEnemy[] Enemies;
        [NMS(Index = 5, Size = 0x6, EnumType = typeof(GcAntagonistGroup.AntagonistGroupEnum))]
        /* 0x090 */ public GcAntagonistFriend[] Friends;
        [NMS(Index = 7)]
        /* 0x120 */ public List<GcAntagonistPerception> Perceptions;
        [NMS(Index = 4)]
        /* 0x130 */ public float CommunicationDelay;
        [NMS(Index = 3)]
        /* 0x134 */ public float ComprehensionFactor;
        [NMS(Index = 0)]
        /* 0x138 */ public GcAntagonistGroup Group;
        [NMS(Index = 1)]
        /* 0x13C */ public float ScarinessFactor;
        [NMS(Index = 2)]
        /* 0x140 */ public float ShockedFactor;
    }
}
