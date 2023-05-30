using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcNGuiElementData : NMSTemplate
    {
        public NMSString0x10 ID;
        public NMSString0x10 PresetID;

        public long CreationTime;

        public bool IsHidden;

        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding29;

        public GcNGuiLayoutData Layout;
    }
}
