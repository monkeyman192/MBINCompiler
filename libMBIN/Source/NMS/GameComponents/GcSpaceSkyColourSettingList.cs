using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAF8A26954101CD98, NameHash = 0x14C4B281A2FBD940)]
    public class GcSpaceSkyColourSettingList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcSolarSystemSkyColourData> Settings;
    }
}
