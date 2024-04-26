using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x4099A36C26276AEC, NameHash = 0x5FE8CF76972566C2)]
    public class GcEffectsGlobals : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x000 */ public TkModelRendererData ResourceRendererData;
        [NMS(Index = 3)]
        /* 0x0B0 */ public TkMaterialResource HologramComponentDefaultMaterial;
        [NMS(Index = 1)]
        /* 0x134 */ public float ClickToPlayCameraOffset;
        [NMS(Index = 0)]
        /* 0x138 */ public float ClickToPlayScale;
    }
}
