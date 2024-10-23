using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDEB2801639FB591D, NameHash = 0x822864FA)]
    public class GcCustomisationBannerImageData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x20A TipText;
        [NMS(Index = 0)]
        /* 0x20 */ public TkTextureResource BannerImage;
        [NMS(Index = 1)]
        /* 0x38 */ public NMSString0x10 LinkedSpecialID;
        [NMS(Index = 2)]
        /* 0x48 */ public bool WideImage;
    }
}
