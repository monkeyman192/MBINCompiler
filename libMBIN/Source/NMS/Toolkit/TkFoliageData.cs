namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCF5018310EDBC8A2, NameHash = 0x678F6A0ACE397B4)]
    public class TkFoliageData : NMSTemplate
    {
        /* 0x00 */ public Colour Colour;
        /* 0x10 */ public float AngleMultiplier;
        /* 0x14 */ public float Density;
        /* 0x18 */ public float DensityVariance;
        /* 0x1C */ public float Scale;
        /* 0x20 */ public NMSString0x80 Material;
        /* 0xA0 */ public bool AngleExponentially;
    }
}
