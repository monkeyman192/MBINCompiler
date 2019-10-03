using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1A8, GUID = 0x7A2164A5AF820818, NameHash = 0x8762991A70BCCE8C)]
    public class GcWikiPage : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x000 */ public string PageID;
        /* 0x020 */ public TkTextureResource Icon;
        [NMS(Size = 0x40)]
        /* 0x0A4 */ public string Content;
        [NMS(Size = 0x40)]
        /* 0x0E4 */ public string VRContent;
        /* 0x124 */ public TkTextureResource ContentImage;
    }
}
