using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x40)]
    public class GcExternalObjectListOptions : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Name;
		[NMS(Size = 0x10)]
		/* 0x10 */ public string ResourceHint;
        /* 0x20 */ public float Probability;
        /* 0x24 */ public GcTerrainTileType TileType;
        /* 0x28 */ public bool AllowLimiting;
        /* 0x29 */ public bool ChooseUsingLifeLevel;
        [NMS(Size = 6, Ignore = true)]
        public byte[] Padding;
        /* 0x30 */ public List<NMSString0x80> Options;
    }
}
