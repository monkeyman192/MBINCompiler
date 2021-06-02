using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1A8, GUID = 0x7A2164A5AF820818, NameHash = 0x8762991A70BCCE8C)]
    public class GcWikiPage : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A PageID;
        /* 0x020 */ public TkTextureResource Icon;
        /* 0x0A4 */ public NMSString0x40 Content;
        /* 0x0E4 */ public NMSString0x40 VRContent;
        /* 0x124 */ public TkTextureResource ContentImage;
    }
}
