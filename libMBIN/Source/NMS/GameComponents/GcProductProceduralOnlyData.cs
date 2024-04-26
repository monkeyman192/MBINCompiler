using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x914B4667BD7F5082, NameHash = 0xEACA21EDB93AD84A)]
    public class GcProductProceduralOnlyData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x000 */ public GcNameGeneratorWord Description;
        [NMS(Index = 7)]
        /* 0x028 */ public TkTextureResource HeroIcon;
        [NMS(Index = 6)]
        /* 0x0AC */ public TkTextureResource Icon;
        [NMS(Index = 4)]
        /* 0x130 */ public int AgeMax;
        [NMS(Index = 3)]
        /* 0x134 */ public int AgeMin;
        [NMS(Index = 2)]
        /* 0x138 */ public int BaseValueMax;
        [NMS(Index = 1)]
        /* 0x13C */ public int BaseValueMin;
        [NMS(Index = 0)]
        /* 0x140 */ public int DropWeight;
    }
}
