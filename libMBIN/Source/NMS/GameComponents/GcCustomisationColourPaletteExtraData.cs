using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x56227E3EC58C1531, NameHash = 0x9B0B9933C035E4C2)]
    public class GcCustomisationColourPaletteExtraData : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> ProductToUnlock;
        /* 0x10 */ public List<NMSString0x20A> TipText;
    }
}
