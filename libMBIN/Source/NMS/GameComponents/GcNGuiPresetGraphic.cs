using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcNGuiPresetGraphic : NMSTemplate
    {
        public NMSString0x10 PresetID;
        public GcNGuiLayoutData Layout;
        [NMS(Size = 0x4)]
        public byte[] Padding3C;

        public TkNGuiGraphicStyle Style;
        public NMSString0x80 Image;
    }
}
