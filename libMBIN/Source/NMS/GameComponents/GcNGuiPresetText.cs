using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcNGuiPresetText : NMSTemplate
    {
        public NMSString0x10 PresetID;
        public GcNGuiLayoutData Layout;
        [NMS(Size = 0x4)]
        public byte[] Padding3C;

        public TkNGuiTextStyle Style;
        public TkNGuiGraphicStyle GraphicStyle;
        public NMSString0x80 Image;
    }
}
