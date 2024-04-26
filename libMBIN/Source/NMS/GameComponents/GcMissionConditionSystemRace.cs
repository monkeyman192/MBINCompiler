using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC8EF5D73DCCC59A9, NameHash = 0x62AA54DDD6FE7CC1)]
    public class GcMissionConditionSystemRace : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcAlienRace Race;
    }
}
