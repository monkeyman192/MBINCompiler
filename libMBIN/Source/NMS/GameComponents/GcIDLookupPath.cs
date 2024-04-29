namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE0CE9AE8BD73EEC9, NameHash = 0x2F5DCE9C70402E02)]
    public class GcIDLookupPath : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x010 */ public NMSString0x800 Path;
        [NMS(Index = 4)]
        /* 0x810 */ public NMSString0x80 DescriptionField;
        [NMS(Index = 5)]
        /* 0x890 */ public NMSString0x80 ImageField;
        [NMS(Index = 2)]
        /* 0x910 */ public NMSString0x80 NameField;
        [NMS(Index = 3)]
        /* 0x990 */ public NMSString0x80 SubTitleField;
    }
}
