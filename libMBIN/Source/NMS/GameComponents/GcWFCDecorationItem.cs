using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x37516E17AC76EC4E, NameHash = 0x9DDB490E0E777CD8)]
    public class GcWFCDecorationItem : NMSTemplate
    {
        /* 0x000 */ public List<NMSString0x10> ApplicableModules;
        /* 0x010 */ public NMSString0x10 Group;
        /* 0x020 */ public NMSString0x10 Name;
        /* 0x030 */ public List<GcWeightedResource> Scenes;
        /* 0x040 */ public GcWFCDecorationFace Back;
        /* 0x0C4 */ public GcWFCDecorationFace Down;
        /* 0x148 */ public GcWFCDecorationFace Forward;
        /* 0x1CC */ public GcWFCDecorationFace Left;
        /* 0x250 */ public GcWFCDecorationFace Right;
        /* 0x2D4 */ public GcWFCDecorationFace Up;
        // size: 0x3
        public enum InsideOutsideEnum : uint {
            Both,
            InteriorOnly,
            ExteriorOnly,
        }
        /* 0x358 */ public InsideOutsideEnum InsideOutside;
        // size: 0x3
        public enum LevelEnum : uint {
            Everywhere,
            GroundLevelOnly,
            AboveGroundOnly,
        }
        /* 0x35C */ public LevelEnum Level;
        /* 0x360 */ public int MaxPerBuilding;
        /* 0x364 */ public int MinPerBuilding;
        /* 0x368 */ public float NoSceneProbability;
        /* 0x36C */ public float RelativeProbability;
        /* 0x370 */ public bool Include;
        /* 0x371 */ public bool RequireAboveTerrain;
        /* 0x372 */ public bool RequireReachable;
        /* 0x373 */ public bool Rotate;
    }
}
