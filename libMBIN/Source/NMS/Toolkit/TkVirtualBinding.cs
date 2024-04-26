using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC58C449AB9F25B01, NameHash = 0xD0287A9FD1DC3163)]
    public class TkVirtualBinding : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 HudLayerID;
        [NMS(Index = 3)]
        /* 0x10 */ public NMSString0x10 SecondaryHudLayerID;
        [NMS(Index = 4)]
        /* 0x20 */ public List<GcInputActions> TogglableActions;
        [NMS(Index = 10)]
        /* 0x30 */ public GcInputActions BottomAction;
        [NMS(Index = 7)]
        /* 0x34 */ public GcInputActions LeftAction;
        [NMS(Index = 8)]
        /* 0x38 */ public GcInputActions RightAction;
        [NMS(Index = 9)]
        /* 0x3C */ public GcInputActions TopAction;
        [NMS(Index = 0)]
        /* 0x40 */ public bool Active;
        [NMS(Index = 1)]
        /* 0x41 */ public bool DefaultActive;
        [NMS(Index = 6)]
        /* 0x42 */ public bool DirectionalActions;
        [NMS(Index = 5)]
        /* 0x43 */ public bool SupportsJoystick;
    }
}
