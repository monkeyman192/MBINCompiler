using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5EC2AD5973679FDE, NameHash = 0x5B824AD343C4561E)]
    public class GcDeathStateData : NMSTemplate
    {
        /* 0x000 */ public GcTextPreset AuthorFont;
        /* 0x070 */ public GcTextPreset QuoteFont;
        /* 0x0E0 */ public GcTextPreset ReasonFont;
        /* 0x150 */ public List<GcDeathQuote> Quotes;
    }
}
