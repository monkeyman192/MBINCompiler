namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x640A8F181059CB4, NameHash = 0x23AEA522)]
    public class TkPlatformButtonPair : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 ButtonId;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 PlatformId;
        [NMS(Index = 2)]
        /* 0x20 */ public Vector2f Size;
    }
}
