using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10C, GUID = 0x818EF9AAA4C46A66, NameHash = 0x85905E340468CC13)]
    public class GcScannerIcon : NMSTemplate
    {
        /* 0x000 */ public TkTextureResource Main;
        /* 0x084 */ public TkTextureResource Small;
        /* 0x108 */ public GcScannerIconHighlightTypes Highlight;
    }
}
