using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x23A3ADA7A3D991C8, NameHash = 0x585832A31F4C2EA1)]
    public class GcNGuiLayerData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public TkNGuiGraphicStyle Style;
        [NMS(Index = 0)]
        /* 0x1E0 */ public GcNGuiElementData ElementData;
        [NMS(Index = 3)]
        /* 0x250 */ public List<NMSTemplate> Children;
        // size: 0x3
        public enum AltModeEnum : uint {
            None,
            Normal,
            Alt,
        }
        [NMS(Index = 5)]
        /* 0x260 */ public AltModeEnum AltMode;
        [NMS(Index = 4)]
        /* 0x264 */ public NMSString0x80 DataFilename;
        [NMS(Index = 2)]
        /* 0x2E4 */ public NMSString0x80 Image;
    }
}
