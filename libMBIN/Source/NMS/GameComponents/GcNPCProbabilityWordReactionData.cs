namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5E3AFAEDE336DCCD, NameHash = 0xE83E88B1C1909A3F)]
    public class GcNPCProbabilityWordReactionData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A NextInteraction;
        [NMS(Index = 1)]
        /* 0x20 */ public float Probability;
    }
}
