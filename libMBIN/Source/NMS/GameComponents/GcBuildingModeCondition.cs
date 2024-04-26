using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEA0A0256EFDACAA5, NameHash = 0x307D1ADF8E3AA83B)]
    public class GcBuildingModeCondition : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5, EnumType = typeof(GcBaseBuildingMode.BaseBuildingModeEnum))]
        /* 0x0 */ public int[] ValidBuildingModes;
    }
}
