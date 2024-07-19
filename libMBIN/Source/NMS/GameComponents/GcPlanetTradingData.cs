using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBCA353D573C320E3, NameHash = 0x34DD4105)]
    public class GcPlanetTradingData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcTradingClass TradingClass;
        [NMS(Index = 0)]
        /* 0x4 */ public GcWealthClass WealthClass;
    }
}
