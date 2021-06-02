using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x10, Size = 0x3B0, GUID = 0xC2B012FCA38A72BF, NameHash = 0x585832A31F4C2EA1)]
    public class GcNGuiLayerData : NMSTemplate
    {
        /* 0x000 */ public GcNGuiElementData ElementData;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x068 */ public byte[] Padding68;
        /* 0x070 */ public TkNGuiGraphicStyle Style;
        /* 0x290 */ public NMSString0x80 Image;
        /* 0x310 */ public List<NMSTemplate> Children;
        /* 0x320 */ public NMSString0x80 DataFilename;
        public enum AltModeEnum { None, Normal, Alt}
        /* 0x3A0 */ public AltModeEnum AltMode;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x3A4 */ public byte[] EndPadding;
    }
}
