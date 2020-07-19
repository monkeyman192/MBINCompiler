using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x5D0, GUID = 0x4CA6C8D6E6DD155B, NameHash = 0x3330409D2B3F48C1)]
    public class GcCreatureRoleData : NMSTemplate
    {
        /* 0x000 */ public GcSeed Seed;
        /* 0x010 */ public GcCreatureTypes CreatureType;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;

        [NMS(Size = 0x10)]
        /* 0x018 */ public string CreatureId;
        /* 0x028 */ public GcCreatureRoleDescription Description;
        /* 0x088 */ public GcCreatureInfo Info;
        /* 0x5A0 */ public GcTerrainTileType TileType;
		/* 0x5A4 */ public GcCreatureDiet Diet;
        /* 0x5A8 */ public float BaseScale;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x5AC */ public byte[] Padding52C;
        [NMS(Size = 0x20)]
        /* 0x5B0 */ public string Filter;
    }
}
