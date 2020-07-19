using System.Collections.Generic;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x42C1BB8D4FAC7A11, NameHash = 0xA84D807B09AAC1E3)]
    public class GcRewardSystemSpecificProductFromList : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> ProductList;
        /* 0x10 */ public int AmountMin;
        /* 0x14 */ public int AmountMax;
        /* 0x18 */ public bool ForceSpecialMessage;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x19 */ public byte[] EndPadding;
    }
}
