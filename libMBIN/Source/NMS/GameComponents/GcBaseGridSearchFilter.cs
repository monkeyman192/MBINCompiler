using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xCCCDAE27335F9916, NameHash = 0xA4186DCC6FC21A11)]
    public class GcBaseGridSearchFilter : NMSTemplate
    {
        /* 0x00 */ public GcLinkNetworkTypes NetworkType;
        /* 0x04 */ public int PartRateIsGreaterThan;
        /* 0x08 */ public int PartRateIsLessThan;
        /* 0x0C */ public int GridRateIsGreaterThan;
        /* 0x10 */ public int GridRateIsLessThan;
        /* 0x14 */ public bool GridHasANegativeRate;
        /* 0x15 */ public bool GridHasAPositiveRate;
        /* 0x16 */ public bool GridIsOnline;
        /* 0x17 */ public bool GridIsNotOnline;
        /* 0x18 */ public int GridHasMinParts;
        /* 0x1C */ public int GridHasMaxParts;
        /* 0x20 */ public int GridHasMinNonPassiveParts;
        /* 0x24 */ public int GridHasMaxNonPassiveParts;
        /* 0x28 */ public bool GridHasPositiveRatePotential;
    }
}
