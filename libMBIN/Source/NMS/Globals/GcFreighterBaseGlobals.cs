using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xD225FA4D7B61C282, NameHash = 0xCB9E3321AA0276BD)]
    public class GcFreighterBaseGlobals : NMSTemplate
    {
        [NMS(Size = 0x5, EnumType = typeof(GcFreighterNPCType.FreighterNPCTypeEnum))]
        /* 0x00 */ public GcFreighterNPCSpawnPriority[] NPCTypeSpawnPriorities;
        /* 0x50 */ public List<GcFreighterRoomNPCData> FreighterRoomNPCData;
        [NMS(Size = 0x5, EnumType = typeof(GcFreighterNPCType.FreighterNPCTypeEnum))]
        /* 0x60 */ public int[] MaxTotalCapacityOfNPCTypes;
        /* 0x74 */ public GcNPCNavSubgraphNodeTypeConnectivity NPCNavNodeConnectivity;
        /* 0x84 */ public int MaxTotalNPCCount;
        /* 0x88 */ public float MinTotalRoomsRequiredPerNPC;
        /* 0x8C */ public float NPCSpawnIntervalTime;
        /* 0x90 */ public float NPCStartSpawnDelayTime;
    }
}
