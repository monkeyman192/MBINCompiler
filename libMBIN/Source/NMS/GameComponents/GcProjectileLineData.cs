using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0xE18B6A30E09DD03B, NameHash = 0xF7D92F84640D5A1D)]
    public class GcProjectileLineData : NMSTemplate
    {
        /* 0x000 */ public float BulletLength;
        /* 0x004 */ public float BulletGlowWidthTime;
        /* 0x008 */ public float BulletGlowWidthMax;
        /* 0x00C */ public float BulletGlowWidthMin;
        /* 0x010 */ public TkCurveType BulletGlowWidthCurve;
        /* 0x014 */ public float BulletScaler;
        /* 0x018 */ public float BulletScalerMinDist;
        /* 0x01C */ public float BulletScalerMaxDist;
        /* 0x020 */ public float BulletMinScaleDistance;
        /* 0x024 */ public float BulletMaxScaleDistance;

    }
}
