namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB0EB58BB3CC340C3, NameHash = 0x43B098E5)]
    public class GcMissionSequenceDisplaySeasonRewardReminder : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public float Time;
    }
}
