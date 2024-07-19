using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD600078744C719D2, NameHash = 0x253868ED)]
    public class GcBuildingFilename : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x2, EnumType = typeof(GcBuildingSystemTypeEnum.BuildingSystemTypeEnum))]
        /* 0x00 */ public VariableSizeString[] LSystem;
        [NMS(Index = 1, Size = 0x2, EnumType = typeof(GcBuildingSystemTypeEnum.BuildingSystemTypeEnum))]
        /* 0x20 */ public VariableSizeString[] Scene;
        [NMS(Index = 2, Size = 0x2, EnumType = typeof(GcBuildingSystemTypeEnum.BuildingSystemTypeEnum))]
        /* 0x40 */ public VariableSizeString[] WFC;
    }
}
