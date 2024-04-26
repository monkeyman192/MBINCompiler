using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC0C272905A6A0283, NameHash = 0xBD1382185246DF07)]
    public class GcPlayerEmote : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x000 */ public GcPlayerEmotePropData PropData;
        [NMS(Index = 1)]
        /* 0x120 */ public NMSString0x20A ChatText;
        [NMS(Index = 17)]
        /* 0x140 */ public NMSString0x20A PetCommandTitle;
        [NMS(Index = 0)]
        /* 0x160 */ public NMSString0x20A Title;
        [NMS(Index = 4)]
        /* 0x180 */ public NMSString0x10 AnimationName;
        [NMS(Index = 3)]
        /* 0x190 */ public NMSString0x10 EmoteID;
        [NMS(Index = 12)]
        /* 0x1A0 */ public NMSString0x10 GekAnimationName;
        [NMS(Index = 13)]
        /* 0x1B0 */ public NMSString0x10 GekLoopAnimUntilMove;
        [NMS(Index = 7)]
        /* 0x1C0 */ public NMSString0x10 LinkedSpecialID;
        [NMS(Index = 9)]
        /* 0x1D0 */ public NMSString0x10 LoopAnimUntilMove;
        [NMS(Index = 15)]
        /* 0x1E0 */ public NMSString0x10 RidingAnimationName;
        [NMS(Index = 6)]
        /* 0x1F0 */ public TkTextureResource Icon;
        [NMS(Index = 18)]
        /* 0x274 */ public TkTextureResource PetCommandIcon;
        [NMS(Index = 14)]
        /* 0x2F8 */ public bool AvailableUnderwater;
        [NMS(Index = 2)]
        /* 0x2F9 */ public bool ChatUsesPrefix;
        [NMS(Index = 10)]
        /* 0x2FA */ public bool CloseMenuOnSelect;
        [NMS(Index = 16)]
        /* 0x2FB */ public bool IsPetCommand;
        [NMS(Index = 11)]
        /* 0x2FC */ public bool MoveToCancel;
        [NMS(Index = 8)]
        /* 0x2FD */ public bool NeverShowInMenu;
    }
}
