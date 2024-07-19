namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF35D7B649D98678F, NameHash = 0x1B60ED73)]
    public class TkFoliageData : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public Colour Colour;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Material;
        [NMS(Index = 4)]
        /* 0x20 */ public float AngleMultiplier;
        [NMS(Index = 2)]
        /* 0x24 */ public float Density;
        [NMS(Index = 3)]
        /* 0x28 */ public float DensityVariance;
        [NMS(Index = 1)]
        /* 0x2C */ public float Scale;
        [NMS(Index = 5)]
        /* 0x30 */ public bool AngleExponentially;
    }
}
