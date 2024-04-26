using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6FD6B29F7E9E501A, NameHash = 0x266F5269ED2C5661)]
    public class GcStatIconTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xBF, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x0 */ public NMSString0x80[] StatIcons;
    }
}
