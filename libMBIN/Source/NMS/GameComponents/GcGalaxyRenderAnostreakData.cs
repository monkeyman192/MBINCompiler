using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC6A8297C630A22AF, NameHash = 0x916C4DD873AEFE6B)]
    public class GcGalaxyRenderAnostreakData : NMSTemplate
    {
        /* 0x00 */ public Colour OuterColour;
        /* 0x10 */ public Colour InnerColour;
        /* 0x20 */ public float VerticalCompression;        // 3E99999Ah
        /* 0x24 */ public float HorizontalScale;            // 3DCCCCCDh
        /* 0x28 */ public float Contrast;                   // 3F000000h
    }
}
