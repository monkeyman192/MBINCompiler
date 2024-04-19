using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x914B4667BD7F5082, NameHash = 0xEACA21EDB93AD84A)]
    public class GcProductProceduralOnlyData : NMSTemplate
    {
        /* 0x000 */ public GcNameGeneratorWord Description;
        /* 0x028 */ public TkTextureResource HeroIcon;
        /* 0x0AC */ public TkTextureResource Icon;
        /* 0x130 */ public int AgeMax;
        /* 0x134 */ public int AgeMin;
        /* 0x138 */ public int BaseValueMax;
        /* 0x13C */ public int BaseValueMin;
        /* 0x140 */ public int DropWeight;
    }
}
