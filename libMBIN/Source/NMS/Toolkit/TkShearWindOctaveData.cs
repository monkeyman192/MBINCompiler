namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xBC50C690B903ED7E, NameHash = 0x23B0CB2EF86A7A9A)]
    public class TkShearWindOctaveData : NMSTemplate
    {
        /* 0x00 */ public float MaxStrength;
        /* 0x04 */ public float MinStrength;
        /* 0x08 */ public float StrengthVariationFreq;
        /* 0x0C */ public float WaveFrequency;
        /* 0x10 */ public float WaveSize;
    }
}
