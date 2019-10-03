using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x640, Alignment = 0x10, GUID = 0x1E719DD28F9420A1, NameHash = 0x4C5F02B93CB08B1A)]
    public class GcNGuiTextData : NMSTemplate
    {
        /* 0x000 */ public GcNGuiElementData Data;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x068 */ public byte[] Padding68;
        /* 0x070 */ public TkNGuiTextStyle Style;
        /* 0x190 */ public TkNGuiGraphicStyle GraphicStyle;
        [NMS(Size = 0x80)]
        /* 0x3A0 */ public string Image;
        [NMS(Size = 0x200)]
        /* 0x420 */ public string Text;
        /* 0x620 */ public bool Special;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x621 */ public byte[] Padding621;
        /* 0x628 */ public List<GcVROverride_Text> VROverrides;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x638 */ public byte[] EndPadding;
    }
}
