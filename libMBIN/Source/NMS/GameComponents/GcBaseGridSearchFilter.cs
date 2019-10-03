using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2C, GUID = 0xBFC0D03E75009117, NameHash = 0xA4186DCC6FC21A11)]
    public class GcBaseGridSearchFilter : NMSTemplate
    {
        public GcLinkNetworkTypes NetworkType;
        public int PartRateIsGreaterThan;
        public int PartRateIsLessThan;
        public int GridRateIsGreaterThan;
        public int GridRateIsLessThan;
        public bool GridHasANegativeRate;
        public bool GridHasAPositiveRate;
        public bool GridIsOnline;
        public bool GridIsNotOnline;
        public int GridHasMinParts;
        public int GridHasMaxParts;
        public int GridHasMinNonPassiveParts;
        public int GridHasMaxNonPassiveParts;
        public bool GridHasPositiveRatePotential;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
