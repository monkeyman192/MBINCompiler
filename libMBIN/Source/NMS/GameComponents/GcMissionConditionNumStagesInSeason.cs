using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4C68DE3FC9D52F24, NameHash = 0xC951FC13)]
    public class GcMissionConditionNumStagesInSeason : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int NumberOfStages;
        [NMS(Index = 1)]
        /* 0x4 */ public TkEqualityEnum Test;
    }
}
