using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE50AD99F966EF6F5, NameHash = 0xAB581862)]
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
