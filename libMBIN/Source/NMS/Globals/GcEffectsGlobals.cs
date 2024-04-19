using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x4099A36C26276AEC, NameHash = 0x5FE8CF76972566C2)]
    public class GcEffectsGlobals : NMSTemplate
    {
        /* 0x000 */ public TkModelRendererData ResourceRendererData;
        /* 0x0B0 */ public TkMaterialResource HologramComponentDefaultMaterial;
        /* 0x134 */ public float ClickToPlayCameraOffset;
        /* 0x138 */ public float ClickToPlayScale;
    }
}
