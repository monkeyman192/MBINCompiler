using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8DDA5D01792AEF7E, NameHash = 0x6B8472FADE3C492C)]
    public class GcProceduralTechnologyData : NMSTemplate
    {
        /* 0x000 */ public Colour Colour;
        /* 0x010 */ public Colour UpgradeColour;
        /* 0x020 */ public NMSString0x20A Group;
        /* 0x040 */ public NMSString0x10 ID;
        /* 0x050 */ public List<GcProceduralTechnologyStatLevel> StatLevels;
        /* 0x060 */ public NMSString0x10 Template;
        /* 0x070 */ public GcProceduralTechnologyCategory Category;
        /* 0x074 */ public int NumStatsMax;
        /* 0x078 */ public int NumStatsMin;
        // size: 0x7
        public enum QualityEnum : uint {
            Normal,
            Rare,
            Epic,
            Legendary,
            Illegal,
            Sentinel,
            Robot,
        }
        /* 0x07C */ public QualityEnum Quality;
        /* 0x080 */ public GcWeightingCurve WeightingCurve;
        /* 0x084 */ public NMSString0x80 Description;
        /* 0x104 */ public NMSString0x80 Name;
        /* 0x184 */ public NMSString0x80 NameLower;
        /* 0x204 */ public NMSString0x80 Subtitle;
    }
}
