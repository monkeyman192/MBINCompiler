using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x41793B4468575F6D, NameHash = 0x4A16D2127CA95139)]
    public class GcItemPriceModifiers : NMSTemplate
    {
        public float SpaceStationMarkup;
        public float LowPriceMod;
        public float HighPriceMod;
        public float BuyBaseMarkup;
        public float BuyMarkupMod;
    }
}