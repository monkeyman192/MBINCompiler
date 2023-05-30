using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcTechnology : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string ID; // 0x10

        [NMS(Size = 0x80)]
        /* 0x010 */ public string Name; // 0x80

        [NMS(Size = 0x80)]
        /* 0x090 */ public string NameLower; // 0x80

        /* 0x110 */ public VariableSizeString Subtitle;
        /* 0x120 */ public VariableSizeString Description;
        /* 0x130 */ public bool Teach;

        [NMS(Size = 0x7, Ignore = true)]
        /* 0x131 */ public byte[] Padding131;

        [NMS(Size = 0x20)]
        /* 0x138 */ public string HintStart;

        [NMS(Size = 0x20)]
        /* 0x158 */ public string HintEnd;

        /* 0x178 */ public TkTextureResource Icon;

        /* 0x200 */ public Colour Colour;
        /* 0x210 */ public int Level;
        /* 0x214 */ public bool Chargeable;
        /* 0x218 */ public int ChargeAmount;

        /* 0x21C */ public GcRealitySubstanceCategory SubstanceCategory;
        /* 0x220 */ public List<NMSString0x10> ChargeBy;
        /* 0x230 */ public bool BuildFullyCharged;
        /* 0x231 */ public bool Upgrade;
        /* 0x232 */ public bool Core;
        /* 0x234 */ public GcTechnologyCategory TechnologyCategory;

        /* 0x238 */ public GcTechnologyRarity TechnologyRarity;

        /* 0x23C */ public float Value;
        /* 0x240 */ public List<GcTechnologyRequirement> Requirements;
        /* 0x250 */ public List<GcStatsBonus> StatBonuses;

        [NMS(Size = 0x10)]
        /* 0x260 */ public string RequiredTech;

        /* 0x270 */ public float RequiredLevel; // todo: is this correct?

        /* 0x280 */ public Colour UpgradeColour;
        /* 0x290 */ public Colour LinkColour;

        [NMS(Size = 0x10)]
        /* 0x2A0 */ public string RewardGroup;
    }
}
