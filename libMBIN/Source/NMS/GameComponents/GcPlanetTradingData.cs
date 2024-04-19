using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x25595393127E4C91, NameHash = 0x645C709EAB3A1F55)]
    public class GcPlanetTradingData : NMSTemplate
    {
        /* 0x0 */ public GcTradingClass TradingClass;
        /* 0x4 */ public GcWealthClass WealthClass;
    }
}
