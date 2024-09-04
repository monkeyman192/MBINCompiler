using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x344BC7BC93D5595E, NameHash = 0x3AD0342F)]
    public class GcDifficultySettingUIOption : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcDifficultySettingEnum> AlsoChangeOptions;
        [NMS(Index = 0)]
        /* 0x10 */ public GcDifficultySettingEnum MainOption;
    }
}
