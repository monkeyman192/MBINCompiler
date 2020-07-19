using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x80, GUID = 0xFCFC86CC50CA838B, NameHash = 0xFD9E29934900184E)]
    public class GcDungeonGenerationParams : NMSTemplate
    {
        /* 0x00 */ public uint SizeX;
        /* 0x04 */ public uint SizeY;
        /* 0x08 */ public uint SizeZ;
        /* 0x0C */ public uint EntranceX;
        /* 0x10 */ public uint EntranceY;
        /* 0x14 */ public uint EntranceZ;
        /* 0x18 */ public uint Rooms;
        /* 0x1C */ public float XProbability;
        /* 0x20 */ public float YProbability;
        /* 0x24 */ public float ZProbability;
        /* 0x28 */ public float StraightProbability;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2C */ public byte[] Padding2C;
        /* 0x30 */ public List<GcDungeonRoomParams> MainRoomTypes;
        /* 0x40 */ public List<NMSString0x10> BranchRoomTypes;
        /* 0x50 */ public List<GcDungeonQuestParams> Quests;
        /* 0x60 */ public List<NMSTemplate> GenerationRules;
        /* 0x70 */ public List<NMSString0x10> PruningRules;
    }
}
