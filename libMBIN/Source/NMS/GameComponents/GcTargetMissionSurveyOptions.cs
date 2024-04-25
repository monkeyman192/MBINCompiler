namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC5A9DABEAEFD7DEE, NameHash = 0x4E7A7CEB00A9346B)]
    public class GcTargetMissionSurveyOptions : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public NMSString0x10 TargetMissionSurveyId;
        [NMS(Index = 4)]
        /* 0x010 */ public NMSString0x80 SurveyHint;
        [NMS(Index = 2)]
        /* 0x090 */ public NMSString0x80 SurveyInactiveHint;
        [NMS(Index = 3)]
        /* 0x110 */ public NMSString0x80 SurveySwapHint;
        [NMS(Index = 5)]
        /* 0x190 */ public NMSString0x80 SurveyVehicleHint;
        [NMS(Index = 1)]
        /* 0x210 */ public bool TargetMissionSurveyDefinitelyExists;
    }
}
