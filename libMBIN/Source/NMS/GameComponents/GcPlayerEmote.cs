using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC0C272905A6A0283, NameHash = 0xBD1382185246DF07)]
    public class GcPlayerEmote : NMSTemplate
    {
        /* 0x000 */ public GcPlayerEmotePropData PropData;
        /* 0x120 */ public NMSString0x20A ChatText;
        /* 0x140 */ public NMSString0x20A PetCommandTitle;
        /* 0x160 */ public NMSString0x20A Title;
        /* 0x180 */ public NMSString0x10 AnimationName;
        /* 0x190 */ public NMSString0x10 EmoteID;
        /* 0x1A0 */ public NMSString0x10 GekAnimationName;
        /* 0x1B0 */ public NMSString0x10 GekLoopAnimUntilMove;
        /* 0x1C0 */ public NMSString0x10 LinkedSpecialID;
        /* 0x1D0 */ public NMSString0x10 LoopAnimUntilMove;
        /* 0x1E0 */ public NMSString0x10 RidingAnimationName;
        /* 0x1F0 */ public TkTextureResource Icon;
        /* 0x274 */ public TkTextureResource PetCommandIcon;
        /* 0x2F8 */ public bool AvailableUnderwater;
        /* 0x2F9 */ public bool ChatUsesPrefix;
        /* 0x2FA */ public bool CloseMenuOnSelect;
        /* 0x2FB */ public bool IsPetCommand;
        /* 0x2FC */ public bool MoveToCancel;
        /* 0x2FD */ public bool NeverShowInMenu;
    }
}
