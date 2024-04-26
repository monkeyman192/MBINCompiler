using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x13409ED5B2B860B4, NameHash = 0xE4AFCD52DEB8A62F)]
    public class GcGalaxyStarColours : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x0 */ public Colour[] ColourByStarType;
    }
}
