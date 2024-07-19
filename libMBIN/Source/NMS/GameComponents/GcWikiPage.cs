using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x18D5D547BE95F905, NameHash = 0x24325E30)]
    public class GcWikiPage : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public NMSString0x20A PageID;
        [NMS(Index = 6)]
        /* 0x020 */ public TkTextureResource ContentImage;
        [NMS(Index = 1)]
        /* 0x038 */ public TkTextureResource Icon;
        [NMS(Index = 2)]
        /* 0x050 */ public NMSString0x40 Content;
        [NMS(Index = 4)]
        /* 0x090 */ public NMSString0x40 VRAnyHandControlContent;
        [NMS(Index = 3)]
        /* 0x0D0 */ public NMSString0x40 VRContent;
        [NMS(Index = 5)]
        /* 0x110 */ public NMSString0x40 VRMoveControllerContent;
    }
}
