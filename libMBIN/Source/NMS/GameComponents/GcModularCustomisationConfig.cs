using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x399D6157457D1765, NameHash = 0x39F4E912A931EB8F)]
    public class GcModularCustomisationConfig : NMSTemplate
    {
        /* 0x000 */ public TkModelRendererData InteractionCameraData;
        /* 0x0B0 */ public TkModelRendererData ModelRenderData;
        /* 0x160 */ public GcExactResource BaseResource;
        /* 0x1F0 */ public NMSString0x20A SubtitleApplyingLocId;
        /* 0x210 */ public NMSString0x20A SubtitleLocId;
        /* 0x230 */ public NMSString0x20A SubtitleSlotsBlockedLocId;
        /* 0x250 */ public NMSString0x20A SubtitleSlotsFullLocId;
        /* 0x270 */ public NMSString0x20A TitleLocId;
        /* 0x290 */ public List<GcModularCustomisationColourGroup> ColourData;
        /* 0x2A0 */ public List<GcModularCustomisationSlotConfig> Slots;
        /* 0x2B0 */ public List<GcModularCustomisationTextureGroup> TextureData;
        /* 0x2C0 */ public GcCustomisationCameraData CameraData;
        /* 0x2F4 */ public float HologramOffset;
        /* 0x2F8 */ public bool IsEnabled;
    }
}
