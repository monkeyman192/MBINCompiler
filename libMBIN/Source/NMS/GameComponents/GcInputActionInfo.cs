using libMBIN.NMS.GameComponents;
using System;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1A00BB5CA3258CC6, NameHash = 0xDEEFD6E4)]
    public class GcInputActionInfo : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public NMSString0x20A ConsoleLocTag;
        [NMS(Index = 6)]
        /* 0x020 */ public NMSString0x20A LabelFallbackLocTag;
        [NMS(Index = 3)]
        /* 0x040 */ public NMSString0x20A LocTag;
        [NMS(Index = 8)]
        /* 0x060 */ public GcFilename OverlayIcon;
        [NMS(Index = 7)]
        /* 0x070 */ public GcFilename SolidIcon;
        [NMS(Index = 9)]
        /* 0x080 */ public GcFilename SpecialIcon;
        [NMS(Index = 10)]
        /* 0x090 */ public GcFilename VirtualButtonIcon;
        // size: 0x8
        [Flags]
        public enum InputActionInfoFlagsEnum : uint {
            None = 0x0,
            AvailableOnConsole = 0x1,
            HideInControlsPage = 0x2,
            HideInControlRebindingPage = 0x4,
            HideInMenusMenu = 0x8,
            OnlyVR = 0x10,
            OnlyNonVR = 0x20,
            IgnoreInSteam = 0x40,
        }
        [NMS(Index = 14)]
        /* 0x0A0 */ public InputActionInfoFlagsEnum InputActionInfoFlags;
        [NMS(Index = 5)]
        /* 0x0A4 */ public GcInputActions LabelDependsOnAction;
        [NMS(Index = 1)]
        /* 0x0A8 */ public GcInputActions Pairing;
        [NMS(Index = 2)]
        /* 0x0AC */ public NMSString0x80 TextTag;
        [NMS(Index = 13)]
        /* 0x12C */ public NMSString0x20 ExternalDigitalAliasId;
        [NMS(Index = 11)]
        /* 0x14C */ public NMSString0x20 ExternalId;
        [NMS(Index = 12)]
        /* 0x16C */ public NMSString0x20 ExternalLoc;
        [NMS(Index = 0)]
        /* 0x18C */ public bool Analogue;
    }
}
