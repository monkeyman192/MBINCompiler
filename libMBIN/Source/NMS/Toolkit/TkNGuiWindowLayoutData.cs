using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkNGuiWindowLayoutData : NMSTemplate
    {
        public NMSString0x80 Name;

        public float PositionX;
        public float PositionY;
        public float SizeX;
        public float SizeY;
        public float Separator;
        public int WindowState;
        public string[] WindowStateValues()
        {
            return new[] { "Open", "Minimised", "Closed" };
        }

        [NMS(Size = 8)]
        public NMSString0x20[] Tabs;
    }
}
