namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x255E1662C1C9140D, NameHash = 0xAEFAC858)]
    public class GcTargetMissionSurveyOptions : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public NMSString0x20A SurveyHint;
        [NMS(Index = 3)]
        /* 0x20 */ public NMSString0x20A SurveyInactiveHint;
        [NMS(Index = 4)]
        /* 0x40 */ public NMSString0x20A SurveySwapHint;
        [NMS(Index = 6)]
        /* 0x60 */ public NMSString0x20A SurveyVehicleHint;
        [NMS(Index = 2)]
        /* 0x80 */ public NMSString0x10 TargetMissionSurveyDefinitelyExistsWithResourceHint;
        [NMS(Index = 0)]
        /* 0x90 */ public NMSString0x10 TargetMissionSurveyId;
        [NMS(Index = 1)]
        /* 0xA0 */ public bool TargetMissionSurveyDefinitelyExists;
    }
}
