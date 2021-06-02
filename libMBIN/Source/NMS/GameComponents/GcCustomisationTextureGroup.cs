using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, Alignment = 0x8, GUID = 0x8437059D0EF05BF2, NameHash = 0xB88B7FCF1DD9F40B)]
    public class GcCustomisationTextureGroup : NMSTemplate
    {
        public NMSString0x10 GroupID;
        public NMSString0x20 Title;
        public NMSString0x10 TextureOptionsGroup;
    }
}
