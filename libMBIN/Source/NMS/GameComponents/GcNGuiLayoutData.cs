using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x840F730B142B3E66, NameHash = 0xEEA58D7B)]
    public class GcNGuiLayoutData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcAccessibleOverride_Layout> AccessibleOverrides;
        [NMS(Index = 0)]
        /* 0x10 */ public List<GcVROverride_Layout> VROverrides;
        [NMS(Index = 6)]
        /* 0x20 */ public float ConstrainAspect;
        [NMS(Index = 5)]
        /* 0x24 */ public float Height;
        [NMS(Index = 7)]
        /* 0x28 */ public float MaxWidth;
        [NMS(Index = 2)]
        /* 0x2C */ public float PositionX;
        [NMS(Index = 3)]
        /* 0x30 */ public float PositionY;
        [NMS(Index = 4)]
        /* 0x34 */ public float Width;
        [NMS(Index = 8)]
        /* 0x38 */ public TkNGuiAlignment Align;
        [NMS(Index = 13)]
        /* 0x3A */ public bool Anchor;
        [NMS(Index = 14)]
        /* 0x3B */ public bool AnchorPercent;
        [NMS(Index = 11)]
        /* 0x3C */ public bool ConstrainProportions;
        [NMS(Index = 12)]
        /* 0x3D */ public bool ForceAspect;
        [NMS(Index = 10)]
        /* 0x3E */ public bool HeightPercentage;
        [NMS(Index = 15)]
        /* 0x3F */ public bool SameLine;
        [NMS(Index = 16)]
        /* 0x40 */ public bool SlowCursorOnHover;
        [NMS(Index = 9)]
        /* 0x41 */ public bool WidthPercentage;
    }
}
