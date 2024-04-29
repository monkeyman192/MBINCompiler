using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6159900AB9F8FE2F, NameHash = 0xF7D92F84640D5A1D)]
    public class GcProjectileLineData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public float BulletGlowWidthMax;
        [NMS(Index = 3)]
        /* 0x04 */ public float BulletGlowWidthMin;
        [NMS(Index = 1)]
        /* 0x08 */ public float BulletGlowWidthTime;
        [NMS(Index = 0)]
        /* 0x0C */ public float BulletLength;
        [NMS(Index = 9)]
        /* 0x10 */ public float BulletMaxScaleDistance;
        [NMS(Index = 8)]
        /* 0x14 */ public float BulletMinScaleDistance;
        [NMS(Index = 5)]
        /* 0x18 */ public float BulletScaler;
        [NMS(Index = 7)]
        /* 0x1C */ public float BulletScalerMaxDist;
        [NMS(Index = 6)]
        /* 0x20 */ public float BulletScalerMinDist;
        [NMS(Index = 4)]
        /* 0x24 */ public TkCurveType BulletGlowWidthCurve;
    }
}
