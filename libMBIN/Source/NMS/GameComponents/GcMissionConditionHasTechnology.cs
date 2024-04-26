namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8E444B511B45E75D, NameHash = 0x7454AD5214251C68)]
    public class GcMissionConditionHasTechnology : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Technology;
        [NMS(Index = 1)]
        /* 0x10 */ public bool AllowPartiallyInstalled;
        [NMS(Index = 3)]
        /* 0x11 */ public bool TakeTechFromSeasonData;
        [NMS(Index = 2)]
        /* 0x12 */ public bool TeachIfNotKnown;
    }
}
