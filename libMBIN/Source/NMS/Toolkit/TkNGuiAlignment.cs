namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x71FA853C1F36341F, NameHash = 0xD1E7F0BE0B98FD48)]
    public class TkNGuiAlignment : NMSTemplate
    {
        // size: 0x3
        public enum HorizontalEnum : byte {
            Left,
            Center,
            Right,
        }
        [NMS(Index = 1)]
        /* 0x0 */ public HorizontalEnum Horizontal;
        // size: 0x3
        public enum VerticalEnum : byte {
            Top,
            Middle,
            Bottom,
        }
        [NMS(Index = 0)]
        /* 0x1 */ public VerticalEnum Vertical;
    }
}
