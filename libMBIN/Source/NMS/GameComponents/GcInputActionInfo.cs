using libMBIN.NMS.GameComponents;
using System;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x982FC228C6126EC6, NameHash = 0x793BE7AABA010DFF)]
    public class GcInputActionInfo : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A ConsoleLocTag;
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
        /* 0x040 */ public InputActionInfoFlagsEnum InputActionInfoFlags;
        /* 0x044 */ public GcInputActions Pairing;
        /* 0x048 */ public NMSString0x80 OverlayIcon;
        /* 0x0C8 */ public NMSString0x80 SolidIcon;
        /* 0x148 */ public NMSString0x80 SpecialIcon;
        /* 0x1C8 */ public NMSString0x80 TextTag;
        /* 0x248 */ public NMSString0x80 VirtualButtonIcon;
        /* 0x2C8 */ public NMSString0x20 ExternalDigitalAliasId;
        /* 0x2E8 */ public NMSString0x20 ExternalId;
        /* 0x308 */ public NMSString0x20 ExternalLoc;
        /* 0x328 */ public bool Analogue;
    }
}
