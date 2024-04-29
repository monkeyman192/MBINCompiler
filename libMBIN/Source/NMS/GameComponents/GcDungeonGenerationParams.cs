using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCB8A66C87F71FE17, NameHash = 0xFD9E29934900184E)]
    public class GcDungeonGenerationParams : NMSTemplate
    {
        [NMS(Index = 12)]
        /* 0x00 */ public List<NMSString0x10> BranchRoomTypes;
        [NMS(Index = 14)]
        /* 0x10 */ public List<NMSTemplate> GenerationRules;
        [NMS(Index = 11)]
        /* 0x20 */ public List<GcDungeonRoomParams> MainRoomTypes;
        [NMS(Index = 15)]
        /* 0x30 */ public List<NMSString0x10> PruningRules;
        [NMS(Index = 13)]
        /* 0x40 */ public List<GcDungeonQuestParams> Quests;
        [NMS(Index = 3)]
        /* 0x50 */ public uint EntranceX;
        [NMS(Index = 4)]
        /* 0x54 */ public uint EntranceY;
        [NMS(Index = 5)]
        /* 0x58 */ public uint EntranceZ;
        [NMS(Index = 6)]
        /* 0x5C */ public uint Rooms;
        [NMS(Index = 0)]
        /* 0x60 */ public uint SizeX;
        [NMS(Index = 1)]
        /* 0x64 */ public uint SizeY;
        [NMS(Index = 2)]
        /* 0x68 */ public uint SizeZ;
        [NMS(Index = 10)]
        /* 0x6C */ public float StraightMultiplier;
        [NMS(Index = 7)]
        /* 0x70 */ public float XProbability;
        [NMS(Index = 8)]
        /* 0x74 */ public float YProbability;
        [NMS(Index = 9)]
        /* 0x78 */ public float ZProbability;
    }
}
