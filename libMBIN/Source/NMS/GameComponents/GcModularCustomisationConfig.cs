using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD0DD6CB1BAE9E3B1, NameHash = 0xF24F11E8)]
    public class GcModularCustomisationConfig : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x000 */ public TkModelRendererData InteractionCameraData;
        [NMS(Index = 7)]
        /* 0x0B0 */ public TkModelRendererData ModelRenderData;
        [NMS(Index = 6)]
        /* 0x160 */ public GcExactResource BaseResource;
        [NMS(Index = 3)]
        /* 0x180 */ public NMSString0x20A SubtitleApplyingLocId;
        [NMS(Index = 2)]
        /* 0x1A0 */ public NMSString0x20A SubtitleLocId;
        [NMS(Index = 5)]
        /* 0x1C0 */ public NMSString0x20A SubtitleSlotsBlockedLocId;
        [NMS(Index = 4)]
        /* 0x1E0 */ public NMSString0x20A SubtitleSlotsFullLocId;
        [NMS(Index = 1)]
        /* 0x200 */ public NMSString0x20A TitleLocId;
        [NMS(Index = 14)]
        /* 0x220 */ public List<GcModularCustomisationColourData> ColourDataPriorityList;
        [NMS(Index = 12)]
        /* 0x230 */ public List<GcModularCustomisationSlotConfig> Slots;
        [NMS(Index = 13)]
        /* 0x240 */ public List<GcModularCustomisationTextureGroup> TextureData;
        [NMS(Index = 9)]
        /* 0x250 */ public GcCustomisationCameraData CameraData;
        [NMS(Index = 10)]
        /* 0x284 */ public float HologramOffset;
        [NMS(Index = 11)]
        /* 0x288 */ public float HologramScale;
        [NMS(Index = 0)]
        /* 0x28C */ public bool IsEnabled;
    }
}
