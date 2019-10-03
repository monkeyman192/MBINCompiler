using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x140, GUID = 0x1B9B9349DABF96CC, NameHash = 0xBD1382185246DF07)]
    public class GcPlayerEmote : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x000 */ public string Title;
        [NMS(Size = 0x20)]
        /* 0x020 */ public string ChatText;
        /* 0x040 */ public bool ChatUsesPrefix;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x041 */ public byte[] Padding41;
        [NMS(Size = 0x10)]
        /* 0x048 */ public string AnimationName;

        /* 0x058 */ public TkTextureResource Icon;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0DC */ public byte[] PaddingD4;
        
        [NMS(Size = 0x10)]
        /* 0x0DE */ public string LinkedSpecialID;
        [NMS(Size = 0x10)]
        /* 0x0F0 */ public string LoopAnimUntilMov;

        /* 0x100 */ public bool CloseMenuOnSelect;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x101 */ public byte[] Padding101;

        [NMS(Size = 0x10)]
        /* 0x108 */ public string GekAnimationName;
        [NMS(Size = 0x10)]
        /* 0x118 */ public string GekLoopAnimUntilMove;

        /* 0x128 */ public bool AvailableUnderwater;

        [NMS(Size = 0x7, Ignore = true)]
        /* 0x129 */ public byte[] Padding129;
        [NMS(Size = 0x10)]
        /* 0x130 */ public string RidingAnimationName;
    }
}
