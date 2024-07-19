using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCFAE228F94A85895, NameHash = 0xE9C038DD)]
    public class GcScannerIcon : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkTextureResource Main;
        [NMS(Index = 1)]
        /* 0x18 */ public TkTextureResource Small;
        [NMS(Index = 2)]
        /* 0x30 */ public GcScannerIconHighlightTypes Highlight;
    }
}
