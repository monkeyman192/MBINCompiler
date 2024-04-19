using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC6C8FE7E3EC66B68, NameHash = 0x1C442B06A4F945F4)]
    public class TkAnimBlendTree : NMSTemplate
    {
        /* 0x00 */ public NMSTemplate Tree;
        /* 0x50 */ public NMSString0x10 Id;
        /* 0x60 */ public TkAnimationGameData GameData;
        /* 0x68 */ public int Priority;
    }
}
