using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD72C2D74B018BA23, NameHash = 0x44DB3EF040C4347F)]
    public class GcDifficultySettingUIOption : NMSTemplate
    {
        /* 0x00 */ public List<GcDifficultySettingEnum> AlsoChangeOptions;
        /* 0x10 */ public GcDifficultySettingEnum MainOption;
    }
}
