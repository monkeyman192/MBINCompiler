using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD7FD36FBF2B9189, NameHash = 0x6F5F53519B901CD4)]
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
