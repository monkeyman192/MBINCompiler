using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC462D4F8119851CF, NameHash = 0xB9B8ADD8C9FFC2D8)]
    public class TkShearWindData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Name;
        [NMS(Index = 9)]
        /* 0x10 */ public TkShearWindOctaveData Octave0;
        [NMS(Index = 10)]
        /* 0x24 */ public TkShearWindOctaveData Octave1;
        [NMS(Index = 11)]
        /* 0x38 */ public TkShearWindOctaveData Octave2;
        [NMS(Index = 12)]
        /* 0x4C */ public TkShearWindOctaveData Octave3;
        [NMS(Index = 3)]
        /* 0x60 */ public float LdsWindSpeed;
        [NMS(Index = 2)]
        /* 0x64 */ public float LdsWindStrength;
        [NMS(Index = 1)]
        /* 0x68 */ public float OverallWindStrength;
        [NMS(Index = 4)]
        /* 0x6C */ public float ShearWindSpeed;
        [NMS(Index = 6)]
        /* 0x70 */ public float WindShearGradientStrength;
        [NMS(Index = 7)]
        /* 0x74 */ public float WindShearToDotLdsFactor;
        [NMS(Index = 5)]
        /* 0x78 */ public float WindShearVertpushStrength;
        [NMS(Index = 8)]
        /* 0x7C */ public float WindStrengthToVertpush;
    }
}
