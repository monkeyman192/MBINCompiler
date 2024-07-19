using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5F38C02961DB3BB7, NameHash = 0x8817C4F1)]
    public class GcPlayerEmote : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x000 */ public GcPlayerEmotePropData PropData;
        [NMS(Index = 1)]
        /* 0x0B0 */ public NMSString0x20A ChatText;
        [NMS(Index = 17)]
        /* 0x0D0 */ public NMSString0x20A PetCommandTitle;
        [NMS(Index = 0)]
        /* 0x0F0 */ public NMSString0x20A Title;
        [NMS(Index = 6)]
        /* 0x110 */ public TkTextureResource Icon;
        [NMS(Index = 18)]
        /* 0x128 */ public TkTextureResource PetCommandIcon;
        [NMS(Index = 4)]
        /* 0x140 */ public NMSString0x10 AnimationName;
        [NMS(Index = 3)]
        /* 0x150 */ public NMSString0x10 EmoteID;
        [NMS(Index = 12)]
        /* 0x160 */ public NMSString0x10 GekAnimationName;
        [NMS(Index = 13)]
        /* 0x170 */ public NMSString0x10 GekLoopAnimUntilMove;
        [NMS(Index = 7)]
        /* 0x180 */ public NMSString0x10 LinkedSpecialID;
        [NMS(Index = 9)]
        /* 0x190 */ public NMSString0x10 LoopAnimUntilMove;
        [NMS(Index = 15)]
        /* 0x1A0 */ public NMSString0x10 RidingAnimationName;
        [NMS(Index = 20)]
        /* 0x1B0 */ public GcResource IconPetCommandResource;
        [NMS(Index = 19)]
        /* 0x1B4 */ public GcResource IconResource;
        [NMS(Index = 14)]
        /* 0x1B8 */ public bool AvailableUnderwater;
        [NMS(Index = 2)]
        /* 0x1B9 */ public bool ChatUsesPrefix;
        [NMS(Index = 10)]
        /* 0x1BA */ public bool CloseMenuOnSelect;
        [NMS(Index = 16)]
        /* 0x1BB */ public bool IsPetCommand;
        [NMS(Index = 11)]
        /* 0x1BC */ public bool MoveToCancel;
        [NMS(Index = 8)]
        /* 0x1BD */ public bool NeverShowInMenu;
    }
}
