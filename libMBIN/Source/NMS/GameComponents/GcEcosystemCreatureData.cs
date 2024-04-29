using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE921D7D87B329B58, NameHash = 0x3DFA2A5571B31ADB)]
    public class GcEcosystemCreatureData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Creature;
        [NMS(Index = 3)]
        /* 0x10 */ public float MaxHeight;
        [NMS(Index = 2)]
        /* 0x14 */ public float MinHeight;
        [NMS(Index = 4)]
        /* 0x18 */ public float Rarity;
        [NMS(Index = 1)]
        /* 0x1C */ public GcTerrainTileType TileType;
    }
}
