using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x18391720734CEAF0, NameHash = 0xA151C99F)]
    public class GcNGuiLayerData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public TkNGuiGraphicStyle Style;
        [NMS(Index = 0)]
        /* 0x210 */ public GcNGuiElementData ElementData;
        [NMS(Index = 3)]
        /* 0x278 */ public List<NMSTemplate> Children;
        [NMS(Index = 4)]
        /* 0x288 */ public VariableSizeString DataFilename;
        [NMS(Index = 2)]
        /* 0x298 */ public VariableSizeString Image;
        // size: 0x5
        public enum AltModeEnum : uint {
            None,
            Normal,
            Alt,
            NeverOnTouch,
            OnlyOnTouch,
        }
        [NMS(Index = 5)]
        /* 0x2A8 */ public AltModeEnum AltMode;
    }
}
