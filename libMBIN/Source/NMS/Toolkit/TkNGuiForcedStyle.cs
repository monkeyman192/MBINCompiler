namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9BEB641914C9DFD6, NameHash = 0x89B44B6A)]
    public class TkNGuiForcedStyle : NMSTemplate
    {
        // size: 0x4
        public enum NGuiForcedStyleEnum : uint {
            None,
            Default,
            Highlight,
            Active,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public NGuiForcedStyleEnum NGuiForcedStyle;
    }
}
