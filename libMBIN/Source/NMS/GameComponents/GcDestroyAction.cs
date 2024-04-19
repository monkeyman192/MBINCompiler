namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD55AF973037FCEEB, NameHash = 0xD01AAF2CB5C146A1)]
    public class GcDestroyAction : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 PlayEffect;
        /* 0x10 */ public bool DestroyAll;
        /* 0x11 */ public bool UseDestructables;
    }
}
