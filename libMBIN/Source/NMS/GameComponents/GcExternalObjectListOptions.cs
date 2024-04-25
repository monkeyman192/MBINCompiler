using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB27A8358427627CA, NameHash = 0x51E8334202D1B952)]
    public class GcExternalObjectListOptions : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Name;
        [NMS(Index = 8)]
        /* 0x10 */ public List<NMSString0x80> Options;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 ResourceHint;
        [NMS(Index = 2)]
        /* 0x30 */ public NMSString0x10 ResourceHintIcon;
        [NMS(Index = 3)]
        /* 0x40 */ public float Probability;
        [NMS(Index = 4)]
        /* 0x44 */ public float SeasonalProbabilityOverride;
        [NMS(Index = 5)]
        /* 0x48 */ public GcTerrainTileType TileType;
        [NMS(Index = 6)]
        /* 0x4C */ public bool AllowLimiting;
        [NMS(Index = 7)]
        /* 0x4D */ public bool ChooseUsingLifeLevel;
    }
}
