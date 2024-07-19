using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x7D2763CF74F70C28, NameHash = 0x8D8BC974)]
    public class GcEffectsGlobals : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public TkModelRendererData ResourceRendererData;
        [NMS(Index = 3)]
        /* 0xB0 */ public TkMaterialResource HologramComponentDefaultMaterial;
        [NMS(Index = 1)]
        /* 0xC8 */ public float ClickToPlayCameraOffset;
        [NMS(Index = 0)]
        /* 0xCC */ public float ClickToPlayScale;
    }
}
