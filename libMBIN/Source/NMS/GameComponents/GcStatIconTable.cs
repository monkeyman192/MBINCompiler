using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9DCBE0D0E8265B30, NameHash = 0xE97F7AA9)]
    public class GcStatIconTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xC7, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x0 */ public VariableSizeString[] StatIcons;
    }
}
