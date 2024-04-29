using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC198EC693DF0524C, NameHash = 0xB2E60FCA3C5550F9)]
    public class GcWaterColourSettingList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPlanetWaterColourData> Settings;
    }
}
