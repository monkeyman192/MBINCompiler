using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x9872E8A6D21507E4, NameHash = 0xCB9E3321AA0276BD)]
    public class GcFreighterBaseGlobals : NMSTemplate
    {
        [NMS(Index = 5, Size = 0x5, EnumType = typeof(GcFreighterNPCType.FreighterNPCTypeEnum))]
        /* 0x00 */ public GcFreighterNPCSpawnPriority[] NPCTypeSpawnPriorities;
        [NMS(Index = 7)]
        /* 0x50 */ public List<GcFreighterRoomNPCData> FreighterRoomNPCData;
        [NMS(Index = 4, Size = 0x5, EnumType = typeof(GcFreighterNPCType.FreighterNPCTypeEnum))]
        /* 0x60 */ public int[] MaxTotalCapacityOfNPCTypes;
        [NMS(Index = 6)]
        /* 0x74 */ public GcNPCNavSubgraphNodeTypeConnectivity NPCNavNodeConnectivity;
        [NMS(Index = 0)]
        /* 0x84 */ public int MaxTotalNPCCount;
        [NMS(Index = 3)]
        /* 0x88 */ public float MinTotalRoomsRequiredPerNPC;
        [NMS(Index = 2)]
        /* 0x8C */ public float NPCSpawnIntervalTime;
        [NMS(Index = 1)]
        /* 0x90 */ public float NPCStartSpawnDelayTime;
    }
}
