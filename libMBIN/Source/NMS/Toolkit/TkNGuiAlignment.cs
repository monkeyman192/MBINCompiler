namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2BE791BF63585465, NameHash = 0x156094FE)]
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
