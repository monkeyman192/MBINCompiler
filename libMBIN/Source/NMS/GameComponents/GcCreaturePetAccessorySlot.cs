namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x33DB223E0D5D9E41, NameHash = 0x7A3E98EFAB95FF53)]
    public class GcCreaturePetAccessorySlot : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 AccessoryGroup;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x100 AttachLocator;
    }
}
