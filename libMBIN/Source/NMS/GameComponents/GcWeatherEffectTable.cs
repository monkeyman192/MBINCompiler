using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1EFBE9411F5D7E5D, NameHash = 0x23C4698E)]
    public class GcWeatherEffectTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcWeatherEffect> Effects;
    }
}
