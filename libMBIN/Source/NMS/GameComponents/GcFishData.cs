using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFE273A01363DC05C, NameHash = 0x9E56997B)]
    public class GcFishData : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public GcSeed MissionSeed;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 ProductID;
        [NMS(Index = 6)]
        /* 0x20 */ public NMSString0x10 RequiresMissionActive;
        [NMS(Index = 9)]
        /* 0x30 */ public float MissionCatchChanceOverride;
        [NMS(Index = 1)]
        /* 0x34 */ public GcItemQuality Quality;
        [NMS(Index = 2)]
        /* 0x38 */ public GcFishSize Size;
        [NMS(Index = 3)]
        /* 0x3C */ public GcFishingTime Time;
        [NMS(Index = 4, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x40 */ public bool[] Biome;
        [NMS(Index = 8)]
        /* 0x50 */ public bool MissionMustAlsoBeSelected;
        [NMS(Index = 5)]
        /* 0x51 */ public bool NeedsStorm;
    }
}
