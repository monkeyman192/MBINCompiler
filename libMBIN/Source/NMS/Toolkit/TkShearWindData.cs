using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC462D4F8119851CF, NameHash = 0xB9B8ADD8C9FFC2D8)]
    public class TkShearWindData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public TkShearWindOctaveData Octave0;
        /* 0x24 */ public TkShearWindOctaveData Octave1;
        /* 0x38 */ public TkShearWindOctaveData Octave2;
        /* 0x4C */ public TkShearWindOctaveData Octave3;
        /* 0x60 */ public float LdsWindSpeed;
        /* 0x64 */ public float LdsWindStrength;
        /* 0x68 */ public float OverallWindStrength;
        /* 0x6C */ public float ShearWindSpeed;
        /* 0x70 */ public float WindShearGradientStrength;
        /* 0x74 */ public float WindShearToDotLdsFactor;
        /* 0x78 */ public float WindShearVertpushStrength;
        /* 0x7C */ public float WindStrengthToVertpush;
    }
}
