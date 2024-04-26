using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD574FC0402980788, NameHash = 0xCEE815614F8FABAF)]
    public class GcCustomisationBannerImageData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x20A TipText;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 LinkedSpecialID;
        [NMS(Index = 0)]
        /* 0x30 */ public TkTextureResource BannerImage;
        [NMS(Index = 2)]
        /* 0xB4 */ public bool WideImage;
    }
}
