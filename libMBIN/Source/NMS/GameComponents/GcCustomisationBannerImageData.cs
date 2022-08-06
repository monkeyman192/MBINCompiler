using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC2DB9DDFB8693F8E, NameHash = 0x0CEE815614F8FABAF)]
    public class GcCustomisationBannerImageData : NMSTemplate
    {
        /* 0x00 */ public TkTextureResource BannerImage;
        /* 0x88 */ public NMSString0x10 LinkedSpecialID;
        /* 0x98 */ public bool WideImage;
        /* 0xA0 */ public NMSString0x20A TipText;
    }
}
