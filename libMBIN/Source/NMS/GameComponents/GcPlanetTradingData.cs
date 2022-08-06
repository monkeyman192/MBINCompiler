using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8BB5E6CD0DF22677, NameHash = 0x645C709EAB3A1F55)]
    public class GcPlanetTradingData : NMSTemplate
    {
        /* 0x00 */ public GcWealthClass WealthClass;
        /* 0x04 */ public GcTradingClass TradingClass;
    }
}
