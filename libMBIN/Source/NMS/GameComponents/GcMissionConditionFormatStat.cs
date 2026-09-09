namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x41D407888E165543, NameHash = 0x9E30CF48)]
    public class GcMissionConditionFormatStat : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Stat;
        [NMS(Index = 1)]
        /* 0x10 */ public VariableSizeString TextTagToUse;
    }
}
