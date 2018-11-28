using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3A758, GUID = 0x2880E385D1BB265C)]
    public class GcBuildingDefinitionTable : NMSTemplate
    {
        [NMS( EnumType = typeof( GcAlienRace.AlienRaceEnum ) )]
        /* 0x00000 */ public GcBuildingFilenameList[] BuildingFiles;

        [NMS( EnumType = typeof( GcBuildingClassification.BuildingClassEnum ) )]
        /* 0x39C00 */ public GcBuildingDefinitionData[] BuildingPlacement;
    }
}
