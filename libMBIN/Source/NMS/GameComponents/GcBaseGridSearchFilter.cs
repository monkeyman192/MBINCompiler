using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x502237C1EE9366E8, NameHash = 0xA4186DCC6FC21A11)]
    public class GcBaseGridSearchFilter : NMSTemplate
    {
        /* 0x00 */ public int GridHasMaxNonPassiveParts;
        /* 0x04 */ public int GridHasMaxParts;
        /* 0x08 */ public int GridHasMinNonPassiveParts;
        /* 0x0C */ public int GridHasMinParts;
        /* 0x10 */ public int GridRateIsGreaterThan;
        /* 0x14 */ public int GridRateIsLessThan;
        /* 0x18 */ public GcLinkNetworkTypes NetworkType;
        /* 0x1C */ public int PartRateIsGreaterThan;
        /* 0x20 */ public int PartRateIsLessThan;
        /* 0x24 */ public bool GridHasANegativeRate;
        /* 0x25 */ public bool GridHasAPositiveRate;
        /* 0x26 */ public bool GridHasPositiveRatePotential;
        /* 0x27 */ public bool GridIsNotOnline;
        /* 0x28 */ public bool GridIsOnline;
    }
}
