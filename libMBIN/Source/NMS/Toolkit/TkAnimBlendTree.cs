using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8DD06E409D473368, NameHash = 0x99CC6BC3)]
    public class TkAnimBlendTree : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSTemplate Tree;
        [NMS(Index = 3)]
        /* 0x20 */ public TkAnimationGameData GameData;
        [NMS(Index = 2)]
        /* 0x2C */ public int Priority;
    }
}
