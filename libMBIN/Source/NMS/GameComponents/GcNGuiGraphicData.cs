using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2F98962422463856, NameHash = 0xB38C6150)]
    public class GcNGuiGraphicData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public TkNGuiGraphicStyle Style;
        [NMS(Index = 0)]
        /* 0x210 */ public GcNGuiElementData ElementData;
        [NMS(Index = 2)]
        /* 0x278 */ public VariableSizeString Image;
        [NMS(Index = 3)]
        /* 0x288 */ public float Angle;
    }
}
