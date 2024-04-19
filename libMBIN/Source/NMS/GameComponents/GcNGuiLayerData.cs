using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x73FAEAF445FBDC01, NameHash = 0x585832A31F4C2EA1)]
    public class GcNGuiLayerData : NMSTemplate
    {
        /* 0x000 */ public TkNGuiGraphicStyle Style;
        /* 0x1E0 */ public GcNGuiElementData ElementData;
        /* 0x250 */ public List<NMSTemplate> Children;
        // size: 0x3
        public enum AltModeEnum : uint {
            None,
            Normal,
            Alt,
        }
        /* 0x260 */ public AltModeEnum AltMode;
        /* 0x264 */ public NMSString0x80 DataFilename;
        /* 0x2E4 */ public NMSString0x80 Image;
    }
}
