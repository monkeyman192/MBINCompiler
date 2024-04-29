namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5776455AF3486B31, NameHash = 0x823BF33F97DC4F32)]
    public class GcCreatureGenerationWeightedListDomainEntry : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 Archetype;
        [NMS(Index = 0)]
        /* 0x10 */ public float Weight;
    }
}
