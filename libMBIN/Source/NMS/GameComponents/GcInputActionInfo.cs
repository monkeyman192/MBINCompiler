using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x455A57E6FF9119A5, NameHash = 0x793BE7AABA010DFF)]
    public class GcInputActionInfo : NMSTemplate
    {
        /* 0x000 */ public bool Analogue;
        /* 0x004 */ public GcInputActions Pairing;
        /* 0x008 */ public NMSString0x80 TextTag;
        /* 0x088 */ public NMSString0x20A LocTag;
        /* 0x0A8 */ public NMSString0x20A ConsoleLocTag;
        /* 0x0C8 */ public NMSString0x80 SolidIcon;
        /* 0x148 */ public NMSString0x80 OverlayIcon;
        /* 0x1C8 */ public NMSString0x80 SpecialIcon;
        /* 0x248 */ public NMSString0x20 ExternalId;
        /* 0x268 */ public NMSString0x20 ExternalLoc;
        /* 0x288 */ public NMSString0x20 ExternalDigitalAliasId;
        // size: 0x5
        [Flags]
        public enum InputActionInfoFlagsEnum {
            None = 0x0, HideInControlsPage = 0x1, HideInMenusMenu = 0x2, OnlyVR = 0x4, OnlyNonVR = 0x8
        }
        [NMSDescription("The enum that describes this field uses Flags. This means that multiple values may be specified simultaneously" +
        "for example, if ValueX = 0x20, ValueY = 0x40: use the notation ValueX|ValueY. Ie. split values with a | character")]
        /* 0x2A8 */ public InputActionInfoFlagsEnum InputActionInfoFlags;
    }
}
