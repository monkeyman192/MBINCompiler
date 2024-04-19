using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAA790A943816F13C, NameHash = 0xFD9E29934900184E)]
    public class GcDungeonGenerationParams : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> BranchRoomTypes;
        /* 0x10 */ public List<NMSTemplate> GenerationRules;
        /* 0x20 */ public List<GcDungeonRoomParams> MainRoomTypes;
        /* 0x30 */ public List<NMSString0x10> PruningRules;
        /* 0x40 */ public List<GcDungeonQuestParams> Quests;
        /* 0x50 */ public uint EntranceX;
        /* 0x54 */ public uint EntranceY;
        /* 0x58 */ public uint EntranceZ;
        /* 0x5C */ public uint Rooms;
        /* 0x60 */ public uint SizeX;
        /* 0x64 */ public uint SizeY;
        /* 0x68 */ public uint SizeZ;
        /* 0x6C */ public float StraightMultiplier;
        /* 0x70 */ public float XProbability;
        /* 0x74 */ public float YProbability;
        /* 0x78 */ public float ZProbability;
    }
}
