using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9EE2B8B24EB493DD, NameHash = 0x5B824AD343C4561E)]
    public class GcDeathStateData : NMSTemplate
    {
        /* 0x00 */ public List<GcDeathQuote> Quotes;
        /* 0x10 */ public GcTextPreset ReasonFont;
        /* 0x80 */ public GcTextPreset QuoteFont;
        /* 0xF0 */ public GcTextPreset AuthorFont;
    }
}
