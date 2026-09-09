using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4136EB85FCA4079B, NameHash = 0x72DD9DBF)]
    public class GcSpacePoiStarData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x0 */ public NMSString0x40[] ColourVariants;
    }
}
