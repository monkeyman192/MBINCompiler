namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB6BCA3F1B468CD9F, NameHash = 0xEBF3EA11)]
    public class TkNGuiLayoutListData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public VariableSizeString Default;
        [NMS(Index = 1)]
        /* 0x10 */ public VariableSizeString Filename;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x80 Name;
        [NMS(Index = 3)]
        /* 0xA0 */ public bool Autosave;
        [NMS(Index = 4)]
        /* 0xA1 */ public bool CanBeDeleted;
    }
}
