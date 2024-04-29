using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCF3DAA2A2B34A94F, NameHash = 0x44DB3EF040C4347F)]
    public class GcDifficultySettingUIOption : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcDifficultySettingEnum> AlsoChangeOptions;
        [NMS(Index = 0)]
        /* 0x10 */ public GcDifficultySettingEnum MainOption;
    }
}
