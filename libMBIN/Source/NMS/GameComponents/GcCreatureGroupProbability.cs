namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFEECAE1AE6297591, NameHash = 0xF0E840DA05227000)]
    public class GcCreatureGroupProbability : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Group;
        [NMS(Index = 1)]
        /* 0x10 */ public float Probability;
    }
}
