using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x909F5380A1E1910C, NameHash = 0x550D77569C679867)]
    public class GcPunctuationDelayData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcPunctuationDelay> PunctuationList;
        [NMS(Index = 1)]
        /* 0x10 */ public float DefaultDelay;
    }
}
