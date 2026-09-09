using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD1635E2B186DCAAD, NameHash = 0xAEC62A33)]
    public class GcTradingSupplyData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x10 Product;
        [NMS(Index = 0)]
        /* 0x10 */ public ulong GalacticAddress;
        [NMS(Index = 4)]
        /* 0x18 */ public ulong Timestamp;
        [NMS(Index = 2)]
        /* 0x20 */ public float Demand;
        [NMS(Index = 5)]
        /* 0x24 */ public GcInteractionType InteractionType;
        [NMS(Index = 1)]
        /* 0x28 */ public float Supply;
        [NMS(Index = 6)]
        /* 0x2C */ public bool IsProduct;
    }
}
