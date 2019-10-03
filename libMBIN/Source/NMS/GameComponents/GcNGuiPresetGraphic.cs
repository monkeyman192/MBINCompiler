using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2E0, GUID = 0x903E0E2379D6A53, NameHash = 0x247C56DDB7B4E25A)]
    public class GcNGuiPresetGraphic : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string PresetID;
        /* 0x010 */ public GcNGuiLayoutData Layout;
        /* 0x050 */ public TkNGuiGraphicStyle Style;
        [NMS(Size = 0x80)]
        /* 0x260 */ public string Image;
    }
}
