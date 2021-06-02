using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x30, GUID = 0xAD794EB2CCE2FD5F, NameHash = 0x2F9B8F940B001C76)]
    public class GcRewardExchangeProduct : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 IDToGive;
        /* 0x10 */ public NMSString0x10 IDToTake;
        /* 0x20 */ public int AmountToGiveMin;
        /* 0x24 */ public int AmountToGiveMax;
        /* 0x28 */ public int AmountToTakeMax;
        /* 0x2C */ public bool HideNewProduct;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x2D */ public byte[] EndPadding;
    }
}
