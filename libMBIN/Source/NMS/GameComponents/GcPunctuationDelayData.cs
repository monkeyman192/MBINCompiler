using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x16415FA471BA366B, NameHash = 0x2B8ECA20)]
    public class GcPunctuationDelayData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcPunctuationDelay> PunctuationList;
        [NMS(Index = 1)]
        /* 0x10 */ public float DefaultDelay;
    }
}
