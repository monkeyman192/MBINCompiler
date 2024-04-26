using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x72F0CA3E44774D4B, NameHash = 0x50D7C1FE13F7260D)]
    public class GcKnownThingsPreset : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSString0x10> KnownProducts;
        [NMS(Index = 3)]
        /* 0x10 */ public List<NMSString0x20A> KnownRefinerRecipes;
        [NMS(Index = 2)]
        /* 0x20 */ public List<NMSString0x10> KnownSpecials;
        [NMS(Index = 0)]
        /* 0x30 */ public List<NMSString0x10> KnownTech;
        [NMS(Index = 5)]
        /* 0x40 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        [NMS(Index = 4)]
        /* 0x50 */ public List<GcWordKnowledge> KnownWords;
    }
}
