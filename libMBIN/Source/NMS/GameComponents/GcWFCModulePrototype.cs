using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x24CDC442E48BD290, NameHash = 0xD64AF9E2)]
    public class GcWFCModulePrototype : NMSTemplate
    {
        [NMS(Index = 17)]
        /* 0x000 */ public GcWFCFace Back;
        [NMS(Index = 16)]
        /* 0x078 */ public GcWFCFace Down;
        [NMS(Index = 20)]
        /* 0x0F0 */ public GcWFCFace Forward;
        [NMS(Index = 15)]
        /* 0x168 */ public GcWFCFace Left;
        [NMS(Index = 18)]
        /* 0x1E0 */ public GcWFCFace Right;
        [NMS(Index = 19)]
        /* 0x258 */ public GcWFCFace Up;
        [NMS(Index = 1)]
        /* 0x2D0 */ public NMSString0x10 Id;
        [NMS(Index = 11)]
        /* 0x2E0 */ public NMSString0x10 LayoutGroup;
        [NMS(Index = 12)]
        /* 0x2F0 */ public List<GcWeightedResource> Scenes;
        [NMS(Index = 14)]
        /* 0x300 */ public List<GcWFCTerrainConstraint> TerrainConstraints;
        // size: 0x3
        public enum FreighterModuleTypeEnum : uint {
            None,
            Room,
            Corridor,
        }
        [NMS(Index = 21)]
        /* 0x310 */ public FreighterModuleTypeEnum FreighterModuleType;
        [NMS(Index = 3)]
        /* 0x314 */ public float RelativeProbability;
        // size: 0x4
        public enum TerrainEditsEnum : uint {
            None,
            ClearEntireBlock,
            UseScene,
            UseBasebuildingEdits,
        }
        [NMS(Index = 13)]
        /* 0x318 */ public TerrainEditsEnum TerrainEdits;
        [NMS(Index = 2)]
        /* 0x31C */ public NMSString0x80 Group;
        [NMS(Index = 0)]
        /* 0x39C */ public NMSString0x80 Name;
        [NMS(Index = 10)]
        /* 0x41C */ public bool DontRotateModel;
        [NMS(Index = 5)]
        /* 0x41D */ public bool ExcludeOnGround;
        [NMS(Index = 6)]
        /* 0x41E */ public bool ExcludeOnTop;
        [NMS(Index = 9)]
        /* 0x41F */ public bool ExcludeRotatedVariants;
        [NMS(Index = 4)]
        /* 0x420 */ public bool Include;
        [NMS(Index = 7)]
        /* 0x421 */ public bool Indoors;
        [NMS(Index = 8)]
        /* 0x422 */ public bool LimitToOnePerLevel;
    }
}
