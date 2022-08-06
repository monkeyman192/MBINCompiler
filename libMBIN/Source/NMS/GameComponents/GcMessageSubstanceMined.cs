using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE507F5B0875EA65B, NameHash = 0x2BC6A341CEA135BF)]
    public class GcMessageSubstanceMined : NMSTemplate
    {
        /* 0x0 */ public int Amount;
        /* 0x8 */ public NMSString0x10 Substance;
    }
}
