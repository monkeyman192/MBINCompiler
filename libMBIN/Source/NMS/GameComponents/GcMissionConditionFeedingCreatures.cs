namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7939D2C838EB4AE0, NameHash = 0x891EECEF6BD18108)]
    public class GcMissionConditionFeedingCreatures : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int MinCreatures;
        [NMS(Index = 1)]
        /* 0x4 */ public bool TakeNumFromSeasonData;
    }
}
