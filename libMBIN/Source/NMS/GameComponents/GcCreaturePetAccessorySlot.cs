namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x33DB223E0D5D9E41, NameHash = 0x25A97B6C)]
    public class GcCreaturePetAccessorySlot : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 AccessoryGroup;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x100 AttachLocator;
    }
}
