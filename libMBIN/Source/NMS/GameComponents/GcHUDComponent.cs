using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcHUDComponent : NMSTemplate
    {
        public NMSString0x10 Id;

        public int PosX;
        public int PosY;
        public int Width;
        public int Height;
        public int Align;

        public string[] AlignValues()
        {
            return new string[] { "Center", "TopLeft", "TopRight", "BottomLeft", "BottomRight" };
        }

        public int Unknown24;
    }
}
