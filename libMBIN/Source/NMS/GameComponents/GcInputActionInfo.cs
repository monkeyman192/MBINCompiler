using libMBIN.NMS.GameComponents;
using System;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x66477DACADA17110, NameHash = 0x793BE7AABA010DFF)]
    public class GcInputActionInfo : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public NMSString0x20A ConsoleLocTag;
        [NMS(Index = 3)]
        /* 0x020 */ public NMSString0x20A LocTag;
        // size: 0x5
        [Flags]
        public enum InputActionInfoFlagsEnum : uint {
            HideInControlsPage = 0x1,
            HideInMenusMenu = 0x2,
            OnlyVR = 0x4,
            OnlyNonVR = 0x8,
            None = 0x0,
        }
        [NMS(Index = 12)]
        /* 0x040 */ public InputActionInfoFlagsEnum InputActionInfoFlags;
        [NMS(Index = 1)]
        /* 0x044 */ public GcInputActions Pairing;
        [NMS(Index = 6)]
        /* 0x048 */ public NMSString0x80 OverlayIcon;
        [NMS(Index = 5)]
        /* 0x0C8 */ public NMSString0x80 SolidIcon;
        [NMS(Index = 7)]
        /* 0x148 */ public NMSString0x80 SpecialIcon;
        [NMS(Index = 2)]
        /* 0x1C8 */ public NMSString0x80 TextTag;
        [NMS(Index = 8)]
        /* 0x248 */ public NMSString0x80 VirtualButtonIcon;
        [NMS(Index = 11)]
        /* 0x2C8 */ public NMSString0x20 ExternalDigitalAliasId;
        [NMS(Index = 9)]
        /* 0x2E8 */ public NMSString0x20 ExternalId;
        [NMS(Index = 10)]
        /* 0x308 */ public NMSString0x20 ExternalLoc;
        [NMS(Index = 0)]
        /* 0x328 */ public bool Analogue;
    }
}
