using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x6987E476ED49F68, NameHash = 0xCE87D0159308C03A)]
    public class TkNoiseFlattenPoint : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public TkNoiseFlattenOptions FlattenType;
        [NMS(Index = 6)]
        /* 0x08 */ public int Classification;
        [NMS(Index = 0)]
        /* 0x0C */ public float Density;
        [NMS(Index = 1)]
        /* 0x10 */ public float FlattenRadius;
        [NMS(Index = 7)]
        /* 0x14 */ public int Placement;
        [NMS(Index = 3)]
        /* 0x18 */ public float TurbulenceAmplitude;
        [NMS(Index = 2)]
        /* 0x1C */ public float TurbulenceFrequency;
        [NMS(Index = 4)]
        /* 0x20 */ public int TurbulenceOctaves;
        [NMS(Index = 10)]
        /* 0x24 */ public bool AddLandingPad;
        [NMS(Index = 9)]
        /* 0x25 */ public bool AddShelter;
        [NMS(Index = 8)]
        /* 0x26 */ public bool AddWaypoint;
    }
}
