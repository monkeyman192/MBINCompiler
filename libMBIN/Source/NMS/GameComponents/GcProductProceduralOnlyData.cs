using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x148, GUID = 0x2DF4B2BD8E92EEA7, NameHash = 0xEACA21EDB93AD84A)]
    public class GcProductProceduralOnlyData : NMSTemplate
    {
        /* 0x000 */ public int DropWeight;
        /* 0x004 */ public int BasevalueMin;
        /* 0x008 */ public int BaseValueMax;
        /* 0x00C */ public int AgeMin;
        /* 0x010 */ public int AgeMax;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x014 */ public byte[] Padding14;
        /* 0x018 */ public GcNameGeneratorWord Description;
        /* 0x040 */ public TkModelResource Icon;
        /* 0x0C4 */ public TkModelResource HeroIcon;
    }
}
