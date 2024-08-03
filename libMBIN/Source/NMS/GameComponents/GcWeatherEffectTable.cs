using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7EB9E1AF2FA0F188, NameHash = 0x23C4698E)]
    public class GcWeatherEffectTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcWeatherEffect> Effects;
    }
}
