namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5DF76DF2866CC002, NameHash = 0x2977C8E531764A2C)]
    public class GcMissionConditionHasCommunicatorSignal : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A SpecificSignalID;
        [NMS(Index = 2)]
        /* 0x20 */ public bool CallMustBePending;
        [NMS(Index = 1)]
        /* 0x21 */ public bool SpecificSignalIsCurrentIntervention;
    }
}
