namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6D06986FAFFCC96F, NameHash = 0xE5AFDAD)]
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
