using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x46C08, GUID = 0x2880E385D1BB265C, NameHash = 0x9808AB95D152F880)]
    public class GcBuildingDefinitionTable : NMSTemplate
    {
        [NMS(Size = 8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x00000 */ public GcBuildingFilenameList[] BuildingFiles;

        [NMS(Size = 0x23, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x46000 */ public GcBuildingDefinitionData[] BuildingPlacement;
    }
}
