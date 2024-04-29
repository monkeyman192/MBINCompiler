using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9DCB9780D009A650, NameHash = 0x5B824AD343C4561E)]
    public class GcDeathStateData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public GcTextPreset AuthorFont;
        [NMS(Index = 2)]
        /* 0x070 */ public GcTextPreset QuoteFont;
        [NMS(Index = 1)]
        /* 0x0E0 */ public GcTextPreset ReasonFont;
        [NMS(Index = 0)]
        /* 0x150 */ public List<GcDeathQuote> Quotes;
    }
}
