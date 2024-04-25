using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD600078744C719D2, NameHash = 0x5E68908664819224)]
    public class GcBuildingFilename : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x2, EnumType = typeof(GcBuildingSystemTypeEnum.BuildingSystemTypeEnum))]
        /* 0x000 */ public NMSString0x80[] LSystem;
        [NMS(Index = 1, Size = 0x2, EnumType = typeof(GcBuildingSystemTypeEnum.BuildingSystemTypeEnum))]
        /* 0x100 */ public NMSString0x80[] Scene;
        [NMS(Index = 2, Size = 0x2, EnumType = typeof(GcBuildingSystemTypeEnum.BuildingSystemTypeEnum))]
        /* 0x200 */ public NMSString0x80[] WFC;
    }
}
