using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF8990B8BF4F70232, NameHash = 0x8762991A70BCCE8C)]
    public class GcWikiPage : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public NMSString0x20A PageID;
        [NMS(Index = 6)]
        /* 0x020 */ public TkTextureResource ContentImage;
        [NMS(Index = 1)]
        /* 0x0A4 */ public TkTextureResource Icon;
        [NMS(Index = 2)]
        /* 0x128 */ public NMSString0x40 Content;
        [NMS(Index = 4)]
        /* 0x168 */ public NMSString0x40 VRAnyHandControlContent;
        [NMS(Index = 3)]
        /* 0x1A8 */ public NMSString0x40 VRContent;
        [NMS(Index = 5)]
        /* 0x1E8 */ public NMSString0x40 VRMoveControllerContent;
    }
}
