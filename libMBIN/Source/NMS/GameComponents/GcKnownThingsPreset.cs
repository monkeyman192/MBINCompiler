using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x72F0CA3E44774D4B, NameHash = 0x50D7C1FE13F7260D)]
    public class GcKnownThingsPreset : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> KnownProducts;
        /* 0x10 */ public List<NMSString0x20A> KnownRefinerRecipes;
        /* 0x20 */ public List<NMSString0x10> KnownSpecials;
        /* 0x30 */ public List<NMSString0x10> KnownTech;
        /* 0x40 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        /* 0x50 */ public List<GcWordKnowledge> KnownWords;
    }
}
