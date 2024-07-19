namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x20D0523D78500E7, NameHash = 0xACD048E2)]
    public class TkNGuiWindowLayoutData : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x0000 */ public int ActiveTabIdx;
        [NMS(Index = 2)]
        /* 0x0004 */ public float PositionX;
        [NMS(Index = 10)]
        /* 0x0008 */ public float PositionXRelative;
        [NMS(Index = 3)]
        /* 0x000C */ public float PositionY;
        [NMS(Index = 11)]
        /* 0x0010 */ public float PositionYRelative;
        [NMS(Index = 8)]
        /* 0x0014 */ public float ScrollX;
        [NMS(Index = 9)]
        /* 0x0018 */ public float ScrollY;
        [NMS(Index = 6)]
        /* 0x001C */ public float Separator;
        [NMS(Index = 4)]
        /* 0x0020 */ public float SizeX;
        [NMS(Index = 12)]
        /* 0x0024 */ public float SizeXRelative;
        [NMS(Index = 5)]
        /* 0x0028 */ public float SizeY;
        [NMS(Index = 13)]
        /* 0x002C */ public float SizeYRelative;
        [NMS(Index = 1, Size = 0x20)]
        /* 0x0030 */ public NMSString0x80[] Tabs;
        [NMS(Index = 0)]
        /* 0x1030 */ public NMSString0x80 Name;
        // size: 0x3
        public enum WindowStateEnum : byte {
            Open,
            Minimised,
            Closed,
        }
        [NMS(Index = 14)]
        /* 0x10B0 */ public WindowStateEnum WindowState;
    }
}
