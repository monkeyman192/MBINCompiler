using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8437059D0EF05BF2, NameHash = 0xB88B7FCF1DD9F40B)]
    public class GcCustomisationTextureGroup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 GroupID;
        /* 0x10 */ public NMSString0x20A Title;
        /* 0x30 */ public NMSString0x10 TextureOptionsGroup;
    }
}
