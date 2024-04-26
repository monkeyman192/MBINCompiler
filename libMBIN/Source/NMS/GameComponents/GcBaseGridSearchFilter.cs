using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x502237C1EE9366E8, NameHash = 0xA4186DCC6FC21A11)]
    public class GcBaseGridSearchFilter : NMSTemplate
    {
        [NMS(Index = 12)]
        /* 0x00 */ public int GridHasMaxNonPassiveParts;
        [NMS(Index = 10)]
        /* 0x04 */ public int GridHasMaxParts;
        [NMS(Index = 11)]
        /* 0x08 */ public int GridHasMinNonPassiveParts;
        [NMS(Index = 9)]
        /* 0x0C */ public int GridHasMinParts;
        [NMS(Index = 3)]
        /* 0x10 */ public int GridRateIsGreaterThan;
        [NMS(Index = 4)]
        /* 0x14 */ public int GridRateIsLessThan;
        [NMS(Index = 0)]
        /* 0x18 */ public GcLinkNetworkTypes NetworkType;
        [NMS(Index = 1)]
        /* 0x1C */ public int PartRateIsGreaterThan;
        [NMS(Index = 2)]
        /* 0x20 */ public int PartRateIsLessThan;
        [NMS(Index = 5)]
        /* 0x24 */ public bool GridHasANegativeRate;
        [NMS(Index = 6)]
        /* 0x25 */ public bool GridHasAPositiveRate;
        [NMS(Index = 13)]
        /* 0x26 */ public bool GridHasPositiveRatePotential;
        [NMS(Index = 8)]
        /* 0x27 */ public bool GridIsNotOnline;
        [NMS(Index = 7)]
        /* 0x28 */ public bool GridIsOnline;
    }
}
