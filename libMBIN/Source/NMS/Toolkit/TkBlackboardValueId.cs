namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF389D6C1037D3BC4, NameHash = 0x9A99DA98FF7577EC)]
    public class TkBlackboardValueId : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Key;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 Value;
    }
}
