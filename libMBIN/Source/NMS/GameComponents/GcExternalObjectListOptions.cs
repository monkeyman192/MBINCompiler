using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDE4BAD5519791942, NameHash = 0x51E8334202D1B952)]
    public class GcExternalObjectListOptions : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
		/* 0x10 */ public NMSString0x10 ResourceHint;
        /* 0x20 */ public NMSString0x10 ResourceHintIcon;
        /* 0x30 */ public float Probability;
        /* 0x34 */ public float SeasonalProbabilityOverride;
        /* 0x38 */ public GcTerrainTileType TileType;
        /* 0x3C */ public bool AllowLimiting;
        /* 0x3D */ public bool ChooseUsingLifeLevel;
        /* 0x40 */ public List<NMSString0x80> Options;
    }
}
