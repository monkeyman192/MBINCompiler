using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBFF25FB08364A24A, NameHash = 0x85905E340468CC13)]
    public class GcScannerIcon : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public TkTextureResource Main;
        [NMS(Index = 1)]
        /* 0x084 */ public TkTextureResource Small;
        [NMS(Index = 2)]
        /* 0x108 */ public GcScannerIconHighlightTypes Highlight;
    }
}
