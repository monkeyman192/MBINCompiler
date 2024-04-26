using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x393AEE313EAF1227, NameHash = 0xB2E60FCA3C5550F9)]
    public class GcWaterColourSettingList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPlanetWaterColourData> Settings;
    }
}
