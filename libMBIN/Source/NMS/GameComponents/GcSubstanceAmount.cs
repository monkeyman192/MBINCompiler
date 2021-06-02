using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x30, GUID = 0x15E8BBC4FDB928FE, NameHash = 0x87586DC48C5F162B)]
    public class GcSubstanceAmount : NMSTemplate
    {
        /* 0x00 */ public int AmountMin;
        /* 0x04 */ public int AmountMax;
        /* 0x08 */ public NMSString0x10 Specific;
        /* 0x18 */ public NMSString0x10 SpecificSecondary;
        /* 0x28 */ public GcRealitySubstanceCategory Category;
        /* 0x2C */ public GcRarity Rarity;
    }
}
