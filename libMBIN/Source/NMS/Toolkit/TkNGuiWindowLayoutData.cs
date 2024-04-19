namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x80CA7ECB56702722, NameHash = 0x9650958F04D49C46)]
    public class TkNGuiWindowLayoutData : NMSTemplate
    {
        /* 0x0000 */ public int ActiveTabIdx;
        /* 0x0004 */ public float PositionX;
        /* 0x0008 */ public float PositionY;
        /* 0x000C */ public float ScrollX;
        /* 0x0010 */ public float ScrollY;
        /* 0x0014 */ public float Separator;
        /* 0x0018 */ public float SizeX;
        /* 0x001C */ public float SizeY;
        [NMS(Size = 0x20)]
        /* 0x0020 */ public NMSString0x80[] Tabs;
        /* 0x1020 */ public NMSString0x80 Name;
        // size: 0x3
        public enum WindowStateEnum : byte {
            Open,
            Minimised,
            Closed,
        }
        /* 0x10A0 */ public WindowStateEnum WindowState;
    }
}
