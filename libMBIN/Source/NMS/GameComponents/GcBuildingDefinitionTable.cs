using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x54A825C6A161A63B, NameHash = 0x9808AB95D152F880)]
    public class GcBuildingDefinitionTable : NMSTemplate
    {
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x00000 */ public GcBuildingFilenameList[] BuildingFiles;
        [NMS(Size = 0x34, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x4E000 */ public GcBuildingDefinitionData[] BuildingPlacement;
        /* 0x4F6C0 */ public List<GcBuildingClusterLayout> ClusterLayouts;
    }
}
