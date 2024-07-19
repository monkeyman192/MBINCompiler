using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x297C599B16517621, NameHash = 0xD022A151)]
    public class GcGalaxyStarColours : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x0 */ public Colour[] ColourByStarType;
    }
}
