using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x74D021303F06166E, NameHash = 0xEB956F6AA5C15F5C)]
    public class GcWFCModulePrototype : NMSTemplate
    {
        /* 0x000 */ public GcWFCFace Back;
        /* 0x078 */ public GcWFCFace Down;
        /* 0x0F0 */ public GcWFCFace Forward;
        /* 0x168 */ public GcWFCFace Left;
        /* 0x1E0 */ public GcWFCFace Right;
        /* 0x258 */ public GcWFCFace Up;
        /* 0x2D0 */ public NMSString0x10 Id;
        /* 0x2E0 */ public NMSString0x10 LayoutGroup;
        /* 0x2F0 */ public List<GcWeightedResource> Scenes;
        /* 0x300 */ public List<GcWFCTerrainConstraint> TerrainConstraints;
        // size: 0x3
        public enum FreighterModuleTypeEnum : uint {
            None,
            Room,
            Corridor,
        }
        /* 0x310 */ public FreighterModuleTypeEnum FreighterModuleType;
        /* 0x314 */ public float RelativeProbability;
        // size: 0x4
        public enum TerrainEditsEnum : uint {
            None,
            ClearEntireBlock,
            UseScene,
            UseBasebuildingEdits,
        }
        /* 0x318 */ public TerrainEditsEnum TerrainEdits;
        /* 0x31C */ public NMSString0x80 Group;
        /* 0x39C */ public NMSString0x80 Name;
        /* 0x41C */ public bool DontRotateModel;
        /* 0x41D */ public bool ExcludeOnGround;
        /* 0x41E */ public bool ExcludeOnTop;
        /* 0x41F */ public bool ExcludeRotatedVariants;
        /* 0x420 */ public bool Include;
        /* 0x421 */ public bool Indoors;
        /* 0x422 */ public bool LimitToOnePerLevel;
    }
}
