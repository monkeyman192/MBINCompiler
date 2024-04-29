using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF5303C3FEA0AD736, NameHash = 0x1C442B06A4F945F4)]
    public class TkAnimBlendTree : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSTemplate Tree;
        [NMS(Index = 0)]
        /* 0x50 */ public NMSString0x10 Id;
        [NMS(Index = 3)]
        /* 0x60 */ public TkAnimationGameData GameData;
        [NMS(Index = 2)]
        /* 0x68 */ public int Priority;
    }
}
