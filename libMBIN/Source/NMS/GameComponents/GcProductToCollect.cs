namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x75CC42F470577AB, NameHash = 0xCAF649FD)]
    public class GcProductToCollect : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Product;
        [NMS(Index = 1)]
        /* 0x10 */ public int Amount;
    }
}
