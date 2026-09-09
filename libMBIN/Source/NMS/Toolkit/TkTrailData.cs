namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB209489FC55CFF46, NameHash = 0x5F4C23C1)]
    public class TkTrailData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public float DistanceThreshold;
        [NMS(Index = 5)]
        /* 0x04 */ public int FrontPoints;
        [NMS(Index = 6)]
        /* 0x08 */ public float FrontUvEnd;
        [NMS(Index = 2)]
        /* 0x0C */ public int MaxPointsPerFrame;
        [NMS(Index = 4)]
        /* 0x10 */ public float PointLife;
        [NMS(Index = 1)]
        /* 0x14 */ public int Points;
        [NMS(Index = 7)]
        /* 0x18 */ public float Tiling;
        [NMS(Index = 0)]
        /* 0x1C */ public float Width;
    }
}
