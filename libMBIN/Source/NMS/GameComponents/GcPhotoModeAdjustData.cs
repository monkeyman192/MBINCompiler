using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB43FEB3C2922650B, NameHash = 0xF2AF28FE)]
    public class GcPhotoModeAdjustData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public float AdjustMax;
        [NMS(Index = 3)]
        /* 0x4 */ public float AdjustMaxRange;
        [NMS(Index = 0)]
        /* 0x8 */ public float AdjustMin;
        [NMS(Index = 4)]
        /* 0xC */ public TkCurveType AdjustMaxCurve;
        [NMS(Index = 1)]
        /* 0xD */ public TkCurveType AdjustMinCurve;
        [NMS(Index = 5)]
        /* 0xE */ public bool Inverted;
    }
}
