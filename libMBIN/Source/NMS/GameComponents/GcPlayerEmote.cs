using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4B7E84539BE68467, NameHash = 0xBD1382185246DF07)]
    public class GcPlayerEmote : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A Title;
        /* 0x020 */ public NMSString0x20A ChatText;
        /* 0x040 */ public bool ChatUsesPrefix;
        /* 0x048 */ public NMSString0x10 AnimationName;
        /* 0x058 */ public TkTextureResource Icon;
        /* 0x0E0 */ public NMSString0x10 LinkedSpecialID;
        /* 0x0F0 */ public bool NeverShowInMenu;
        /* 0x0F8 */ public NMSString0x10 LoopAnimUntilMove;
        /* 0x108 */ public bool CloseMenuOnSelect;
        /* 0x109 */ public bool MoveToCancel;
        /* 0x110 */ public NMSString0x10 GekAnimationName;
        /* 0x120 */ public NMSString0x10 GekLoopAnimUntilMove;
        /* 0x130 */ public bool AvailableUnderwater;
        /* 0x138 */ public NMSString0x10 RidingAnimationName;
        /* 0x148 */ public bool IsPetCommand;
        /* 0x150 */ public NMSString0x20A PetCommandTitle;
        /* 0x170 */ public TkTextureResource PetCommandIcon;
    }
}
