using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x290, GUID = 0x314017B046B3959E, NameHash = 0x6B8472FADE3C492C)]
    public class GcProceduralTechnologyData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string ID;
        [NMS(Size = 0x10)]
        /* 0x010 */ public string Template;
        [NMS(Size = 0x20)]
        /* 0x020 */ public string Group;
        [NMS(Size = 0x80)]
        /* 0x040 */ public string Name;
        [NMS(Size = 0x80)]
        /* 0x0C0 */ public string NameLower;
        [NMS(Size = 0x80)]
        /* 0x140 */ public string Subtitle;
        [NMS(Size = 0x80)]
        /* 0x1C0 */ public string Description;
        /* 0x240 */ public Colour Colour;
		public enum QualityEnum { Normal, Rare, Epic, Legendary }
		/* 0x250 */ public QualityEnum Quality;
        /* 0x254 */ public GcProceduralTechnologyCategory Category;
        /* 0x258 */ public int NumStatsMin;
        /* 0x25C */ public int NumStatsMax;
        /* 0x260 */ public GcWeightingCurve WeightingCurve;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x264 */ public byte[] Padding264;
        /* 0x270 */ public Colour UpgradeColour;
        /* 0x280 */ public List<GcProceduralTechnologyStatLevel> StatLevels;
    }
}
