using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcDisplayText : NMSTemplate
    {
        public int HUDTextDisplayType;
        public string[] HUDTextDisplayTypeValues()
        {
            return new[] { "Full", "Compact", "EyeLevel", "Prompt", "Tooltip" };
        }

        public NMSString0x100 Title;
        public NMSString0x100 Subtitle1;
        public NMSString0x100 Subtitle2;
    }
}
