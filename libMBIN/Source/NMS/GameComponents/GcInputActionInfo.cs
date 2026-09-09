using libMBIN.NMS.GameComponents;
using System;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA8F2F0E3A4A4CD6E, NameHash = 0xDEEFD6E4)]
    public class GcInputActionInfo : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public NMSString0x20A ConsoleLocTag;
        [NMS(Index = 3)]
        /* 0x020 */ public NMSString0x20A LocTag;
        [NMS(Index = 6)]
        /* 0x040 */ public GcFilename OverlayIcon;
        [NMS(Index = 5)]
        /* 0x050 */ public GcFilename SolidIcon;
        [NMS(Index = 7)]
        /* 0x060 */ public GcFilename SpecialIcon;
        [NMS(Index = 8)]
        /* 0x070 */ public GcFilename VirtualButtonIcon;
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
        [NMS(Index = 12)]
        /* 0x080 */ public InputActionInfoFlagsEnum InputActionInfoFlags;
        [NMS(Index = 1)]
        /* 0x084 */ public GcInputActions Pairing;
        [NMS(Index = 2)]
        /* 0x088 */ public NMSString0x80 TextTag;
        [NMS(Index = 11)]
        /* 0x108 */ public NMSString0x20 ExternalDigitalAliasId;
        [NMS(Index = 9)]
        /* 0x128 */ public NMSString0x20 ExternalId;
        [NMS(Index = 10)]
        /* 0x148 */ public NMSString0x20 ExternalLoc;
        [NMS(Index = 0)]
        /* 0x168 */ public bool Analogue;
    }
}
