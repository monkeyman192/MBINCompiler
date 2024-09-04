using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x101407FF5EE9BEBC, NameHash = 0x23C4698E)]
    public class GcWeatherEffectTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcWeatherEffect> Effects;
    }
}
