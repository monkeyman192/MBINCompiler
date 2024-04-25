using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x748832DDC7606FA0, NameHash = 0x6341093281E2ADC1)]
    public class GcDifficultyOptionUIGroup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A HeadingLocID;
        [NMS(Index = 1)]
        /* 0x20 */ public List<GcDifficultySettingUIOption> DifficultyOptions;
    }
}
