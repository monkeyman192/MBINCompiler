using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD4665C5C1C4BCE67, NameHash = 0x4ECF05CB)]
    public class GcCustomisationColourPaletteExtraData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<NMSString0x10> ProductToUnlock;
        [NMS(Index = 1)]
        /* 0x10 */ public List<NMSString0x20A> TipText;
    }
}
