using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xBEFA838B717588ED, NameHash = 0xED10CD4D4540B757)]
    public class TkNGuiRectanglePulseEffect : NMSTemplate
    {
        /* 0x0 */ public float PulseOffset;
        /* 0x4 */ public float PulseRate;
        /* 0x8 */ public float PulseWidth;
        /* 0xC */ public TkCurveType PulseAlphaCurve;
        /* 0xD */ public TkCurveType PulseSizeCurve;
    }
}
