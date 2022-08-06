using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDAADDA98B194C4C1, NameHash = 0x5FE8CF76972566C2)]
    public class GcEffectsGlobals : NMSTemplate
    {
        /* 0x00 */ public float ClickToPlayScale;
        /* 0x04 */ public float ClickToPlayCameraOffset;
        /* 0x10 */ public TkModelRendererData ResourceRendererData;
    }
}
