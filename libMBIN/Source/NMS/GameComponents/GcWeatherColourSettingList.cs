using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF903952DA007FB2D, NameHash = 0x6A59D641)]
    public class GcWeatherColourSettingList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPlanetWeatherColourData> Settings;
    }
}
