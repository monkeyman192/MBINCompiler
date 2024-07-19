namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x67A3C9C66F037049, NameHash = 0x8AAAA061)]
    public class TkLSystemRuleTemplate : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString LSystem;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x20 Name;
    }
}
