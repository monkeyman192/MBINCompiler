namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x786394FFE4D8E05, NameHash = 0x2F9B8F940B001C76)]
    public class GcRewardExchangeProduct : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 IDToGive;
        /* 0x10 */ public NMSString0x10 IDToTake;
        /* 0x20 */ public int AmountToGiveMax;
        /* 0x24 */ public int AmountToGiveMin;
        /* 0x28 */ public int AmountToTakeMax;
        /* 0x2C */ public bool ForceSpecialMessage;
        /* 0x2D */ public bool HideNewProduct;
    }
}
