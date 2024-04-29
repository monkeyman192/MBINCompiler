namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD9528A6EB34CA189, NameHash = 0x40643395614391FA)]
    public class TkNGuiUserSettings : NMSTemplate
    {
        [NMS(Index = 2, Size = 0xA)]
        /* 0x000 */ public NMSString0x100[] FileBrowserRecents;
        [NMS(Index = 1)]
        /* 0xA00 */ public NMSString0x100 LastActiveLayout;
        [NMS(Index = 0)]
        /* 0xB00 */ public NMSString0x100 LastLoadedModel;
    }
}
