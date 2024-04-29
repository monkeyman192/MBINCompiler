using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB927A1941EF80792, NameHash = 0xB5D0CD9B9ED4C2E8)]
    public class GcWeatherColourSettingList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPlanetWeatherColourData> Settings;
    }
}
