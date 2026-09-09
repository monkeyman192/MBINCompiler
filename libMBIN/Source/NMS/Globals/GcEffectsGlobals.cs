using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x9E86AB2BC842B110, NameHash = 0x8D8BC974)]
    public class GcEffectsGlobals : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public TkModelRendererData ResourceRendererData;
        [NMS(Index = 3)]
        /* 0xC0 */ public TkMaterialResource HologramComponentDefaultMaterial;
        [NMS(Index = 1)]
        /* 0xD8 */ public float ClickToPlayCameraOffset;
        [NMS(Index = 0)]
        /* 0xDC */ public float ClickToPlayScale;
    }
}
