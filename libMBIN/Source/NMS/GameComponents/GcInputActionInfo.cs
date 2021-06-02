using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x290, GUID = 0x800C6BACE678BE27, NameHash = 0x793BE7AABA010DFF)]
    public class GcInputActionInfo : NMSTemplate
    {
        /* 0x000 */ public bool Analogue;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x001 */ public byte[] Padding1;
        /* 0x004 */ public GcInputActions Pairing;
        /* 0x008 */ public NMSString0x80 TextTag;
        /* 0x088 */ public NMSString0x20 LocTag;
        /* 0x0A8 */ public NMSString0x80 SolidIcon;
        /* 0x128 */ public NMSString0x80 OverlayIcon;
        /* 0x1A8 */ public NMSString0x80 SpecialIcon;
        /* 0x228 */ public NMSString0x20 ExternalId;
        /* 0x248 */ public NMSString0x20 ExternalLoc;
        /* 0x268 */ public NMSString0x20 ExternalDigitalAliasId;
        public enum InputActionInfoFlagsEnum { None = 0x0, HideInControlsPage = 0x1, OnlyVR = 0x2, OnlyNonVR = 0x4 }
        /* 0x288 */ public InputActionInfoFlagsEnum InputActionInfoFlags;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x28C */ public byte[] EndPadding;
    }
}
