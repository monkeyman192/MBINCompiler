namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC5605EA5AEB12E68, NameHash = 0xEC5C654507FD5E75)]
    public class GcExpeditionDifficultyKeyframe : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float Difficulty;
        [NMS(Index = 0)]
        /* 0x4 */ public int EventNumber;
    }
}
