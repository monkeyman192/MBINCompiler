using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5251E7722ED022F1, NameHash = 0x1655415A)]
    public class GcSpaceSkyColourSettingList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcSolarSystemSkyColourData> Settings;
    }
}
