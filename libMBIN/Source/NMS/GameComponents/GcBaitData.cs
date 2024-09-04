using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x73919151F7278A3A, NameHash = 0xC12B753A)]
    public class GcBaitData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ProductID;
        [NMS(Index = 1, Size = 0x5, EnumType = typeof(GcItemQuality.ItemQualityEnum))]
        /* 0x10 */ public float[] RarityBoosts;
        [NMS(Index = 2, Size = 0x4, EnumType = typeof(GcFishSize.FishSizeEnum))]
        /* 0x24 */ public float[] SizeBoosts;
        [NMS(Index = 3)]
        /* 0x34 */ public float DayTimeBoost;
        [NMS(Index = 4)]
        /* 0x38 */ public float NightTimeBoost;
        [NMS(Index = 5)]
        /* 0x3C */ public float StormBoost;
    }
}
