using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB1B47600BF300C2D, NameHash = 0x4793141D)]
    public class GcProductProceduralOnlyData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public GcNameGeneratorWord Description;
        [NMS(Index = 7)]
        /* 0x28 */ public TkTextureResource HeroIcon;
        [NMS(Index = 6)]
        /* 0x40 */ public TkTextureResource Icon;
        [NMS(Index = 4)]
        /* 0x58 */ public int AgeMax;
        [NMS(Index = 3)]
        /* 0x5C */ public int AgeMin;
        [NMS(Index = 2)]
        /* 0x60 */ public int BaseValueMax;
        [NMS(Index = 1)]
        /* 0x64 */ public int BaseValueMin;
        [NMS(Index = 0)]
        /* 0x68 */ public int DropWeight;
    }
}
