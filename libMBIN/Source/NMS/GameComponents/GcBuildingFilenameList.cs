using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x72439A91D6E21AB5, NameHash = 0x7322E012)]
    public class GcBuildingFilenameList : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x37, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x0 */ public GcBuildingFilename[] BuildingFiles;
    }
}
