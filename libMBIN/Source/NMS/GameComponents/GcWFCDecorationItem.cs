using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB981B6289F777D77, NameHash = 0x9DDB490E0E777CD8)]
    public class GcWFCDecorationItem : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Name;
        /* 0x010 */ public NMSString0x10 Group;
        /* 0x020 */ public float RelativeProbability;
        /* 0x024 */ public float NoSceneProbability;
        /* 0x028 */ public bool Include;
        /* 0x030 */ public List<GcWeightedResource> Scenes;
        /* 0x040 */ public List<NMSString0x10> ApplicableModules;
        /* 0x050 */ public bool Rotate;
        /* 0x051 */ public bool RequireReachable;
        /* 0x054 */ public int MaxPerBuilding;
        /* 0x058 */ public int MinPerBuilding;
        /* 0x05C */ public bool RequireAboveTerrain;
        public enum InsideOutsideEnum { Both, InteriorOnly, ExteriorOnly }
        /* 0x060 */ public InsideOutsideEnum InsideOutside;
        public enum LevelEnum { Everywhere, GroundLevelOnly, AboveGroundOnly }
        /* 0x064 */ public LevelEnum Level;
        /* 0x068 */ public GcWFCDecorationFace Left;
        /* 0x0EC */ public GcWFCDecorationFace Down;
        /* 0x170 */ public GcWFCDecorationFace Back;
        /* 0x1F4 */ public GcWFCDecorationFace Right;
        /* 0x278 */ public GcWFCDecorationFace Up;
        /* 0x2FC */ public GcWFCDecorationFace Forward;
    }
}
