using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkNGuiAlignment : NMSTemplate
    {
        public int Vertical;
        public int Horizontal;

        public string[] VerticalValues()
        {
            return new[] { "Top", "Middle", "Bottom" };
        }


        public string[] HorizontalValues()
        {
            return new[] { "Left", "Center", "Right" };
        }
    }
}
