using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD41641375CF977E5, NameHash = 0x645C709EAB3A1F55)]
    public class GcPlanetTradingData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcTradingClass TradingClass;
        [NMS(Index = 0)]
        /* 0x4 */ public GcWealthClass WealthClass;
    }
}
