namespace MBINCompiler.Models.Structs
{
    public class TkShearWindData : NMSTemplate
    {
        /* 0x000 */ public string Name;
        /* 0x010 */ public float OverallWindStrength;
		/* 0x014 */ public float LdsWindStrength;
		/* 0x018 */ public float LdsWindSpeed;
		/* 0x01C */ public float ShearWindSpeed;
		/* 0x020 */ public float WindShearVertpushStrength;
		/* 0x024 */ public float WindShearGradientStrength;
		/* 0x028 */ public float WindShearToDotLdsFactor;
		/* 0x02C */ public tkShearWindOctaveData Octave0;
		/* 0x040 */ public tkShearWindOctaveData Octave1;
		/* 0x054 */ public tkShearWindOctaveData Octave2;
		/* 0x068 */ public tkShearWindOctaveData Octave3;
    }
}
