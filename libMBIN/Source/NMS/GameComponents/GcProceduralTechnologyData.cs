using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5C8E35AE5D7AE4F5, NameHash = 0x4F77FA42)]
    public class GcProceduralTechnologyData : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x000 */ public Colour Colour;
        [NMS(Index = 14)]
        /* 0x010 */ public Colour UpgradeColour;
        [NMS(Index = 2)]
        /* 0x020 */ public NMSString0x20A Group;
        [NMS(Index = 0)]
        /* 0x040 */ public NMSString0x10 ID;
        [NMS(Index = 15)]
        /* 0x050 */ public List<GcProceduralTechnologyStatLevel> StatLevels;
        [NMS(Index = 1)]
        /* 0x060 */ public NMSString0x10 Template;
        [NMS(Index = 9)]
        /* 0x070 */ public GcProceduralTechnologyCategory Category;
        [NMS(Index = 12)]
        /* 0x074 */ public int NumStatsMax;
        [NMS(Index = 11)]
        /* 0x078 */ public int NumStatsMin;
        // size: 0x8
        public enum QualityEnum : uint {
            Normal,
            Rare,
            Epic,
            Legendary,
            Illegal,
            Sentinel,
            Robot,
            SeaTrash,
        }
        [NMS(Index = 8)]
        /* 0x07C */ public QualityEnum Quality;
        [NMS(Index = 13)]
        /* 0x080 */ public GcWeightingCurve WeightingCurve;
        [NMS(Index = 6)]
        /* 0x084 */ public NMSString0x80 Description;
        [NMS(Index = 3)]
        /* 0x104 */ public NMSString0x80 Name;
        [NMS(Index = 4)]
        /* 0x184 */ public NMSString0x80 NameLower;
        [NMS(Index = 5)]
        /* 0x204 */ public NMSString0x80 Subtitle;
        [NMS(Index = 10)]
        /* 0x284 */ public bool IsBiggsProcTech;
    }
}
