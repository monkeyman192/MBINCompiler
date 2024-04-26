namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4D0A817667D4BAA9, NameHash = 0xF50715D349F22A12)]
    public class TkNGuiLayoutListData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public NMSString0x80 Default;
        [NMS(Index = 1)]
        /* 0x080 */ public NMSString0x80 Filename;
        [NMS(Index = 0)]
        /* 0x100 */ public NMSString0x80 Name;
        [NMS(Index = 3)]
        /* 0x180 */ public bool Autosave;
    }
}
