using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3B13A71C347938D6, NameHash = 0xE97F7AA9)]
    public class GcStatIconTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xC3, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x0 */ public VariableSizeString[] StatIcons;
    }
}
