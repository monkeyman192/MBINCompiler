using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x99A1A56E9CAA31FD, NameHash = 0xCEE71E03D7326B71)]
    public class GcNGuiLayoutData : NMSTemplate
    {
        /* 0x00 */ public float PositionX;
        /* 0x04 */ public float PositionY;
        /* 0x08 */ public float Width; 
        /* 0x0C */ public bool WidthPercentage;
        /* 0x10 */ public float Height;
        /* 0x14 */ public bool HeightPercentage;
        /* 0x15 */ public bool ConstrainProportions;
        /* 0x18 */ public float ConstrainAspect;
        /* 0x1C */ public bool ForceAspect;
        /* 0x1D */ public bool Anchor;
        /* 0x1E */ public bool AnchorPercent;
        /* 0x1F */ public bool SameLine;
        /* 0x20 */ public TkNGuiAlignment Align;
        /* 0x28 */ public bool SlowCursorOnHover;
        /* 0x2C */ public float MaxWidth;
        /* 0x30 */ public List<GcVROverride_Layout> VROverrides;
        /* 0x40 */ public List<GcAccessibleOverride_Layout> AccessibleOverrides;
    }
}
