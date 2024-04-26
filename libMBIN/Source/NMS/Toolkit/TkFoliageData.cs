namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCF5018310EDBC8A2, NameHash = 0x678F6A0ACE397B4)]
    public class TkFoliageData : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public Colour Colour;
        [NMS(Index = 4)]
        /* 0x10 */ public float AngleMultiplier;
        [NMS(Index = 2)]
        /* 0x14 */ public float Density;
        [NMS(Index = 3)]
        /* 0x18 */ public float DensityVariance;
        [NMS(Index = 1)]
        /* 0x1C */ public float Scale;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x80 Material;
        [NMS(Index = 5)]
        /* 0xA0 */ public bool AngleExponentially;
    }
}
