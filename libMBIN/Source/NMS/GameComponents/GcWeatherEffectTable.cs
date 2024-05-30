using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x93F5A32AF2BDB3AE, NameHash = 0x6AE3CB3B6A5A155D)]
    public class GcWeatherEffectTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcWeatherEffect> Effects;
    }
}
