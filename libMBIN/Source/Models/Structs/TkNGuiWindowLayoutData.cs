namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x10A4)]
    public class TkNGuiWindowLayoutData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x0000 */ public string Name;

        /* 0x0080 */ public float PositionX;
        /* 0x0084 */ public float PositionY;
        /* 0x0088 */ public float SizeX;
        /* 0x008C */ public float SizeY;
        /* 0x0090 */ public float Separator;
        /* 0x0094 */ public int WindowState;
        public string[] WindowStateValues()
        {
            return new[] { "Open", "Minimised", "Closed" };
        }

        [NMS(Size = 0x20)]
        /* 0x0098 */ public NMSString0x80[] Tabs;
        /* 0x1098 */ public int ActiveTabIdx;
        /* 0x109C */ public float ScrollX;
        /* 0x10A0 */ public float ScrollY;
    }
}
