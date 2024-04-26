using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDA91BB5D56A58448, NameHash = 0xB5D0CD9B9ED4C2E8)]
    public class GcWeatherColourSettingList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPlanetWeatherColourData> Settings;
    }
}
