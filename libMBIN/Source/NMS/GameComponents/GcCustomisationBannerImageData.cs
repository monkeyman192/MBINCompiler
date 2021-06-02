using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xC0, GUID = 0xC2DB9DDFB8693F8E, NameHash = 0x0CEE815614F8FABAF)]
    public class GcCustomisationBannerImageData : NMSTemplate
    {
        /* 0x00 */ public TkTextureResource BannerImage;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x84 */ public byte[] Padding84;
        /* 0x88 */ public NMSString0x10 LinkedSpecialID;
        /* 0x98 */ public bool WideImage;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x99 */ public byte[] Padding99;
        /* 0xA0 */ public NMSString0x20 TipText;
    }
}
