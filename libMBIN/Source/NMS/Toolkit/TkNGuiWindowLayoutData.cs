namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x80CA7ECB56702722, NameHash = 0x9650958F04D49C46)]
    public class TkNGuiWindowLayoutData : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x0000 */ public int ActiveTabIdx;
        [NMS(Index = 2)]
        /* 0x0004 */ public float PositionX;
        [NMS(Index = 3)]
        /* 0x0008 */ public float PositionY;
        [NMS(Index = 8)]
        /* 0x000C */ public float ScrollX;
        [NMS(Index = 9)]
        /* 0x0010 */ public float ScrollY;
        [NMS(Index = 6)]
        /* 0x0014 */ public float Separator;
        [NMS(Index = 4)]
        /* 0x0018 */ public float SizeX;
        [NMS(Index = 5)]
        /* 0x001C */ public float SizeY;
        [NMS(Index = 1, Size = 0x20)]
        /* 0x0020 */ public NMSString0x80[] Tabs;
        [NMS(Index = 0)]
        /* 0x1020 */ public NMSString0x80 Name;
        // size: 0x3
        public enum WindowStateEnum : byte {
            Open,
            Minimised,
            Closed,
        }
        [NMS(Index = 10)]
        /* 0x10A0 */ public WindowStateEnum WindowState;
    }
}
