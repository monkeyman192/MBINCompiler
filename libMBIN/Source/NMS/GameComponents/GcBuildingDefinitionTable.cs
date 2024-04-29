using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9E79206E6FECC2B6, NameHash = 0x9808AB95D152F880)]
    public class GcBuildingDefinitionTable : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x37, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x0000 */ public GcBuildingDefinitionData[] BuildingPlacement;
        [NMS(Index = 2)]
        /* 0x1810 */ public List<GcBuildingClusterLayout> ClusterLayouts;
        [NMS(Index = 0, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x1820 */ public GcBuildingFilenameList[] BuildingFiles;
    }
}
