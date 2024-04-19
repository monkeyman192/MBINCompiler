using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x50342415C20360EF, NameHash = 0x3DFA2A5571B31ADB)]
    public class GcEcosystemCreatureData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Creature;
        /* 0x10 */ public float MaxHeight;
        /* 0x14 */ public float MinHeight;
        /* 0x18 */ public float Rarity;
        /* 0x1C */ public GcTerrainTileType TileType;
    }
}
