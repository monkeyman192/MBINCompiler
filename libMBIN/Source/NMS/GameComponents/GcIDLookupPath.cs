namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x187B5D6B66702576, NameHash = 0x2F5DCE9C70402E02)]
    public class GcIDLookupPath : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x010 */ public NMSString0x800 Path;
        [NMS(Index = 5)]
        /* 0x810 */ public NMSString0x80 DescriptionField;
        [NMS(Index = 6)]
        /* 0x890 */ public NMSString0x80 ImageField;
        [NMS(Index = 3)]
        /* 0x910 */ public NMSString0x80 NameField;
        [NMS(Index = 4)]
        /* 0x990 */ public NMSString0x80 SubTitleField;
        [NMS(Index = 2)]
        /* 0xA10 */ public bool GlobalSort;
    }
}
