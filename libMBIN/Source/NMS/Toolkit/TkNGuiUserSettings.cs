namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xEEB4228A1493C3FB, NameHash = 0x40643395614391FA)]
    public class TkNGuiUserSettings : NMSTemplate
    {
        [NMS(Size = 0xA)]
        /* 0x000 */ public NMSString0x100[] FileBrowserRecents;
        /* 0xA00 */ public NMSString0x100 LastActiveLayout;
        /* 0xB00 */ public NMSString0x100 LastLoadedModel;
    }
}
