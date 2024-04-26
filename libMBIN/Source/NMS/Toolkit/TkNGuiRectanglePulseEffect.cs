using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xBEFA838B717588ED, NameHash = 0xED10CD4D4540B757)]
    public class TkNGuiRectanglePulseEffect : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float PulseOffset;
        [NMS(Index = 2)]
        /* 0x4 */ public float PulseRate;
        [NMS(Index = 0)]
        /* 0x8 */ public float PulseWidth;
        [NMS(Index = 3)]
        /* 0xC */ public TkCurveType PulseAlphaCurve;
        [NMS(Index = 4)]
        /* 0xD */ public TkCurveType PulseSizeCurve;
    }
}
