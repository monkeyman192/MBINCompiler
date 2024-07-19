using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x29E1DE07801B106, NameHash = 0x8EA66BD5)]
    public class GcWaterColourSettingList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPlanetWaterColourData> Settings;
    }
}
