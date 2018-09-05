namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x60)]
    public class TkAnimBlendTree : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        /* 0x10 */ public NMSTemplate Tree;
        /* 0x58 */ public int Priority;
        /* 0x5C */ public TkAnimationGameData GameData;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
