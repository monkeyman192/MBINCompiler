using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x214F596AAFB8F6D2, NameHash = 0x16AA0D1F)]
    public class TkVirtualBinding : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x20A CustomLocID;
        [NMS(Index = 4)]
        /* 0x20 */ public List<TkVirtualBindingAltLayer> AltHudLayerIDs;
        [NMS(Index = 2)]
        /* 0x30 */ public NMSString0x10 HudLayerID;
        [NMS(Index = 5)]
        /* 0x40 */ public List<GcInputActions> TogglableActions;
        [NMS(Index = 11)]
        /* 0x50 */ public GcInputActions BottomAction;
        [NMS(Index = 8)]
        /* 0x54 */ public GcInputActions LeftAction;
        [NMS(Index = 9)]
        /* 0x58 */ public GcInputActions RightAction;
        [NMS(Index = 10)]
        /* 0x5C */ public GcInputActions TopAction;
        [NMS(Index = 0)]
        /* 0x60 */ public bool Active;
        [NMS(Index = 1)]
        /* 0x61 */ public bool DefaultActive;
        [NMS(Index = 7)]
        /* 0x62 */ public bool DirectionalActions;
        [NMS(Index = 6)]
        /* 0x63 */ public bool SupportsJoystick;
    }
}
