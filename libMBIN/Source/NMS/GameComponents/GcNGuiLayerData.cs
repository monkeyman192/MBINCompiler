using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x10, Size = 0x3A0, GUID = 0x4B7E457B03E3DAA6, NameHash = 0x585832A31F4C2EA1)]
    public class GcNGuiLayerData : NMSTemplate
    {
        /* 0x000 */ public GcNGuiElementData ElementData;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x068 */ public byte[] Padding68;
        /* 0x070 */ public TkNGuiGraphicStyle Style;
        [NMS(Size = 0x80)]
        /* 0x280 */ public string Image;
        /* 0x300 */ public List<NMSTemplate> Children;
        [NMS(Size = 0x80)]
        /* 0x310 */ public string DataFilename;
        public enum AltModeEnum { None, Normal, Alt}
        /* 0x390 */ public AltModeEnum AltMode;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x394 */ public byte[] EndPadding;
    }
}
