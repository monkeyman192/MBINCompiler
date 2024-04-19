using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC58C449AB9F25B01, NameHash = 0xD0287A9FD1DC3163)]
    public class TkVirtualBinding : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 HudLayerID;
        /* 0x10 */ public NMSString0x10 SecondaryHudLayerID;
        /* 0x20 */ public List<GcInputActions> TogglableActions;
        /* 0x30 */ public GcInputActions BottomAction;
        /* 0x34 */ public GcInputActions LeftAction;
        /* 0x38 */ public GcInputActions RightAction;
        /* 0x3C */ public GcInputActions TopAction;
        /* 0x40 */ public bool Active;
        /* 0x41 */ public bool DefaultActive;
        /* 0x42 */ public bool DirectionalActions;
        /* 0x43 */ public bool SupportsJoystick;
    }
}
