namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E33D607D3817686, NameHash = 0x2F5DCE9C70402E02)]
    public class GcIDLookupPath : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Id;
        /* 0x010 */ public NMSString0x800 Path;
        /* 0x810 */ public NMSString0x80 DescriptionField;
        /* 0x890 */ public NMSString0x80 ImageField;
        /* 0x910 */ public NMSString0x80 NameField;
        /* 0x990 */ public NMSString0x80 SubTitleField;
    }
}
