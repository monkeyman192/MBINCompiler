using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4B0C5D217593D849, NameHash = 0xE97F7AA9)]
    public class GcStatIconTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xC5, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x0 */ public VariableSizeString[] StatIcons;
    }
}
