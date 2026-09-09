using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x498E1E2481F51355, NameHash = 0xE97F7AA9)]
    public class GcStatIconTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xD1, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x0 */ public GcFilename[] StatIcons;
    }
}
