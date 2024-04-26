namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2670BF9C30F864C0, NameHash = 0x7A3E98EFAB95FF53)]
    public class GcCreaturePetAccessorySlot : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 AccessoryGroup;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x100 AttachLocator;
    }
}
