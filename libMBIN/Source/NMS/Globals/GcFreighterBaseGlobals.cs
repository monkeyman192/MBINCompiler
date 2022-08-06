using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x06CD970039C9D523, NameHash = 0xCB9E3321AA0276BD)]
    public class GcFreighterBaseGlobals : NMSTemplate
    {
        /* 0x00 */ public int MaxTotalNPCCount;
        /* 0x04 */ public float NPCStartSpawnDelayTime;
        /* 0x08 */ public float NPCSpawnIntervalTime;
        /* 0x0C */ public float MinTotalRoomsRequiredPerNPC;
        [NMS(Size = 0x5, EnumType = typeof(GcFreighterNPCType.FreighterNPCTypeEnum))]
        /* 0x10 */ public int[] MaxTotalCapacityOfNPCTypes;
        [NMS(Size = 0x5, EnumType = typeof(GcFreighterNPCType.FreighterNPCTypeEnum))]
        /* 0x28 */ public GcFreighterNPCSpawnPriority[] NPCTypeSpawnPriorities;
        /* 0x78 */ public GcNPCNavSubgraphNodeTypeConnectivity NPCNavNodeConnectivity;
        /* 0x88 */ public List<GcFreighterRoomNPCData> FreighterRoomNPCData;
    }
}
