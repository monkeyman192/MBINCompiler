using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x10FF6832C5905B11, NameHash = 0xEB956F6AA5C15F5C)]
    public class GcWFCModulePrototype : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Name;
        /* 0x080 */ public NMSString0x10 Id;
        /* 0x090 */ public NMSString0x80 Group;
        /* 0x110 */ public float RelativeProbability;
        /* 0x114 */ public bool Include;
        /* 0x115 */ public bool ExcludeOnGround;
        /* 0x116 */ public bool ExcludeOnTop;
        /* 0x117 */ public bool Indoors;
        /* 0x118 */ public bool LimitToOnePerLevel;
        /* 0x119 */ public bool ExcludeRotatedVariants;
        /* 0x11A */ public bool DontRotateModel;
        /* 0x120 */ public NMSString0x10 LayoutGroup;
        /* 0x130 */ public List<GcWeightedResource> Scenes;
        public enum TerrainEditsEnum { None, ClearEntireBlock, UseScene, UseBasebuildingEdits }
        /* 0x140 */ public TerrainEditsEnum TerrainEdits;
        /* 0x148 */ public List<GcWFCTerrainConstraint> TerrainConstraints;
        /* 0x158 */ public GcWFCFace Left;
        /* 0x1D8 */ public GcWFCFace Down;
        /* 0x258 */ public GcWFCFace Back;
        /* 0x2D8 */ public GcWFCFace Right;
        /* 0x358 */ public GcWFCFace Up;
        /* 0x3D8 */ public GcWFCFace Forward;
        public enum FreighterModuleTypeEnum { None, Room, Corridor }
        /* 0x458 */ public FreighterModuleTypeEnum FreighterModuleType;
    }
}
