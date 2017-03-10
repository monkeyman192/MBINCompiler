namespace MBINCompiler.Models.Structs
{
    public class TkShearWindOctaveData : NMSTemplate
    {
        /* 0x000 */ public float MinStrength;
        /* 0x004 */ public float MaxStrength;
		/* 0x008 */ public float StrengthVariationFreq;
		/* 0x00C */ public float WaveSize;
		/* 0x010 */ public float WaveFrequency;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
