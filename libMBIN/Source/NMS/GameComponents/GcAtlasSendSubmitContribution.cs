namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF9ABC14D825E9E66, NameHash = 0x489FC19669F32DA6)]
    public class GcAtlasSendSubmitContribution : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int Contribution;
        [NMS(Index = 0)]
        /* 0x4 */ public int MissionIndex;
    }
}
