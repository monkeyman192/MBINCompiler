using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEA27B0FBCCD36680, NameHash = 0x39F4E912A931EB8F)]
    public class GcModularCustomisationConfig : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x000 */ public TkModelRendererData InteractionCameraData;
        [NMS(Index = 7)]
        /* 0x0B0 */ public TkModelRendererData ModelRenderData;
        [NMS(Index = 6)]
        /* 0x160 */ public GcExactResource BaseResource;
        [NMS(Index = 3)]
        /* 0x1F0 */ public NMSString0x20A SubtitleApplyingLocId;
        [NMS(Index = 2)]
        /* 0x210 */ public NMSString0x20A SubtitleLocId;
        [NMS(Index = 5)]
        /* 0x230 */ public NMSString0x20A SubtitleSlotsBlockedLocId;
        [NMS(Index = 4)]
        /* 0x250 */ public NMSString0x20A SubtitleSlotsFullLocId;
        [NMS(Index = 1)]
        /* 0x270 */ public NMSString0x20A TitleLocId;
        [NMS(Index = 12)]
        /* 0x290 */ public List<GcModularCustomisationColourGroup> ColourData;
        [NMS(Index = 11)]
        /* 0x2A0 */ public List<GcModularCustomisationSlotConfig> Slots;
        [NMS(Index = 13)]
        /* 0x2B0 */ public List<GcModularCustomisationTextureGroup> TextureData;
        [NMS(Index = 9)]
        /* 0x2C0 */ public GcCustomisationCameraData CameraData;
        [NMS(Index = 10)]
        /* 0x2F4 */ public float HologramOffset;
        [NMS(Index = 0)]
        /* 0x2F8 */ public bool IsEnabled;
    }
}
