namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x90BB4D028350EF77, NameHash = 0xF818362C38FEA359)]
    public class TkLSystemGlobalVariation : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public int Variations;
        [NMS(Index = 1)]
        /* 0x04 */ public NMSString0x80 Model;
        [NMS(Index = 0)]
        /* 0x84 */ public NMSString0x20 Name;
    }
}
