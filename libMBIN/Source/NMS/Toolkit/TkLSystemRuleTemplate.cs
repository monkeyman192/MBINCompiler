namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8B6983BE023BBC0A, NameHash = 0x89F774448E48DD4A)]
    public class TkLSystemRuleTemplate : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x80 LSystem;
        [NMS(Index = 0)]
        /* 0x80 */ public NMSString0x20 Name;
    }
}
