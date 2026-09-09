using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8AD2313454C4DC6A, NameHash = 0x822864FA)]
    public class GcCustomisationBannerImageData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public NMSString0x20A TipText;
        [NMS(Index = 1)]
        /* 0x20 */ public TkTextureResource BannerImage;
        [NMS(Index = 0)]
        /* 0x38 */ public NMSString0x10 ID;
        [NMS(Index = 2)]
        /* 0x48 */ public NMSString0x10 LinkedSpecialID;
        [NMS(Index = 4)]
        /* 0x58 */ public bool IsSpecialAllianceBanner;
        [NMS(Index = 3)]
        /* 0x59 */ public bool WideImage;
    }
}
