using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x37516E17AC76EC4E, NameHash = 0x9DDB490E0E777CD8)]
    public class GcWFCDecorationItem : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x000 */ public List<NMSString0x10> ApplicableModules;
        [NMS(Index = 1)]
        /* 0x010 */ public NMSString0x10 Group;
        [NMS(Index = 0)]
        /* 0x020 */ public NMSString0x10 Name;
        [NMS(Index = 5)]
        /* 0x030 */ public List<GcWeightedResource> Scenes;
        [NMS(Index = 16)]
        /* 0x040 */ public GcWFCDecorationFace Back;
        [NMS(Index = 15)]
        /* 0x0C4 */ public GcWFCDecorationFace Down;
        [NMS(Index = 19)]
        /* 0x148 */ public GcWFCDecorationFace Forward;
        [NMS(Index = 14)]
        /* 0x1CC */ public GcWFCDecorationFace Left;
        [NMS(Index = 17)]
        /* 0x250 */ public GcWFCDecorationFace Right;
        [NMS(Index = 18)]
        /* 0x2D4 */ public GcWFCDecorationFace Up;
        // size: 0x3
        public enum InsideOutsideEnum : uint {
            Both,
            InteriorOnly,
            ExteriorOnly,
        }
        [NMS(Index = 12)]
        /* 0x358 */ public InsideOutsideEnum InsideOutside;
        // size: 0x3
        public enum LevelEnum : uint {
            Everywhere,
            GroundLevelOnly,
            AboveGroundOnly,
        }
        [NMS(Index = 13)]
        /* 0x35C */ public LevelEnum Level;
        [NMS(Index = 9)]
        /* 0x360 */ public int MaxPerBuilding;
        [NMS(Index = 10)]
        /* 0x364 */ public int MinPerBuilding;
        [NMS(Index = 3)]
        /* 0x368 */ public float NoSceneProbability;
        [NMS(Index = 2)]
        /* 0x36C */ public float RelativeProbability;
        [NMS(Index = 4)]
        /* 0x370 */ public bool Include;
        [NMS(Index = 11)]
        /* 0x371 */ public bool RequireAboveTerrain;
        [NMS(Index = 8)]
        /* 0x372 */ public bool RequireReachable;
        [NMS(Index = 7)]
        /* 0x373 */ public bool Rotate;
    }
}
