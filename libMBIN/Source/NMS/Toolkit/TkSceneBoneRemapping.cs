namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4303F72D523C7C23, NameHash = 0x8EBBD5819BF9FEBA)]
    public class TkSceneBoneRemapping : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x80 FromBone;
        [NMS(Index = 1)]
        /* 0x80 */ public NMSString0x80 ToBone;
    }
}
