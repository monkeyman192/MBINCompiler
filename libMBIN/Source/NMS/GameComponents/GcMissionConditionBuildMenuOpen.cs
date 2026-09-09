using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3DA7031FC4A1ADF3, NameHash = 0x9865A933)]
    public class GcMissionConditionBuildMenuOpen : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcBaseBuildingSecondaryMode SecondaryMode;
        [NMS(Index = 0)]
        /* 0x4 */ public bool CheckSecondaryMode;
    }
}
