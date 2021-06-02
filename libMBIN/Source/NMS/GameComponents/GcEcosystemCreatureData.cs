using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0xFF82E7E0C3AA09E6, NameHash = 0x3DFA2A5571B31ADB)]
    public class GcEcosystemCreatureData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Creature;
        /* 0x10 */ public GcTerrainTileType TileType;
        /* 0x14 */ public float MinHeight;
        /* 0x18 */ public float MaxHeight;
        /* 0x1C */ public float Rarity;
    }
}
