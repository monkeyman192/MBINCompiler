namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFC7E542334A352B9, NameHash = 0x1E4A17D964305DC4)]
    public class GcMissionConditionTechnologyKnown : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Technology;
        [NMS(Index = 1)]
        /* 0x10 */ public bool DependentOnSeasonMilestone;
        [NMS(Index = 2)]
        /* 0x11 */ public bool TakeTechFromSeasonData;
    }
}
