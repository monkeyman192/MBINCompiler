using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x650, Alignment = 0x10, GUID = 0x62F5488712061AE6, NameHash = 0x4C5F02B93CB08B1A)]
    public class GcNGuiTextData : NMSTemplate
    {
        /* 0x000 */ public GcNGuiElementData ElementData;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x068 */ public byte[] Padding68;
        /* 0x070 */ public TkNGuiTextStyle Style;
        /* 0x190 */ public TkNGuiGraphicStyle GraphicStyle;
        /* 0x3B0 */ public NMSString0x80 Image;
        /* 0x430 */ public NMSString0x200 Text;
        /* 0x630 */ public bool Special;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x631 */ public byte[] Padding631;
        /* 0x638 */ public List<GcVROverride_Text> VROverrides;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x648 */ public byte[] EndPadding;
    }
}
