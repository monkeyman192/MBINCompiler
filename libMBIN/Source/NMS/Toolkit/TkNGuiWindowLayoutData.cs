using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x10A4, GUID = 0x72F5B7416AB51616, NameHash = 0x9650958F04D49C46)]
    public class TkNGuiWindowLayoutData : NMSTemplate
    {
        /* 0x0000 */ public NMSString0x80 Name;
        /* 0x0080 */ public float PositionX;
        /* 0x0084 */ public float PositionY;
        /* 0x0088 */ public float SizeX;
        /* 0x008C */ public float SizeY;
        /* 0x0090 */ public float Separator;
		public enum WindowStateEnum { Open, Minimised, Closed }
		public WindowStateEnum WindowState;
        [NMS(Size = 0x20)]
        /* 0x0098 */ public NMSString0x80[] Tabs;
        /* 0x1098 */ public int ActiveTabIdx;
        /* 0x109C */ public float ScrollX;
        /* 0x10A0 */ public float ScrollY;
    }
}
