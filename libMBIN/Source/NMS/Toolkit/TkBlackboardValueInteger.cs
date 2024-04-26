namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xAF041AAB56FCE9C3, NameHash = 0x66E627EC0C57305C)]
    public class TkBlackboardValueInteger : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Key;
        [NMS(Index = 1)]
        /* 0x10 */ public int Value;
    }
}
