using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCD402697FFDFC91B, NameHash = 0xCE87D0159308C03A)]
    public class TkNoiseFlattenPoint : NMSTemplate
    {
        /* 0x00 */ public TkNoiseFlattenOptions FlattenType;
        /* 0x08 */ public int Classification;
        /* 0x0C */ public float Density;
        /* 0x10 */ public float FlattenRadius;
        /* 0x14 */ public int Placement;
        /* 0x18 */ public float TurbulenceAmplitude;
        /* 0x1C */ public float TurbulenceFrequency;
        /* 0x20 */ public int TurbulenceOctaves;
        /* 0x24 */ public bool AddLandingPad;
        /* 0x25 */ public bool AddShelter;
        /* 0x26 */ public bool AddWaypoint;
    }
}
