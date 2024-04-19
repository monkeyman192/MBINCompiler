using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x89656832E5D5FE94, NameHash = 0x6F5F53519B901CD4)]
    public class GcPhotoModeAdjustData : NMSTemplate
    {
        /* 0x0 */ public float AdjustMax;
        /* 0x4 */ public float AdjustMaxRange;
        /* 0x8 */ public float AdjustMin;
        /* 0xC */ public TkCurveType AdjustMaxCurve;
        /* 0xD */ public TkCurveType AdjustMinCurve;
        /* 0xE */ public bool Inverted;
    }
}
