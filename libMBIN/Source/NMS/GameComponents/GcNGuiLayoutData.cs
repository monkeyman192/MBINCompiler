using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6BF5030552548903, NameHash = 0xCEE71E03D7326B71)]
    public class GcNGuiLayoutData : NMSTemplate
    {
        /* 0x00 */ public List<GcAccessibleOverride_Layout> AccessibleOverrides;
        /* 0x10 */ public List<GcVROverride_Layout> VROverrides;
        /* 0x20 */ public float ConstrainAspect;
        /* 0x24 */ public float Height;
        /* 0x28 */ public float MaxWidth;
        /* 0x2C */ public float PositionX;
        /* 0x30 */ public float PositionY;
        /* 0x34 */ public float Width;
        /* 0x38 */ public TkNGuiAlignment Align;
        /* 0x3A */ public bool Anchor;
        /* 0x3B */ public bool AnchorPercent;
        /* 0x3C */ public bool ConstrainProportions;
        /* 0x3D */ public bool ForceAspect;
        /* 0x3E */ public bool HeightPercentage;
        /* 0x3F */ public bool SameLine;
        /* 0x40 */ public bool SlowCursorOnHover;
        /* 0x41 */ public bool WidthPercentage;
    }
}
