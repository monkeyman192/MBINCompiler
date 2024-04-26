using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x90AA9CA552847F04, NameHash = 0x16C7720D83E61CDB)]
    public class GcWeirdCreatureRewardList : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x1B, EnumType = typeof(GcBiomeSubType.BiomeSubTypeEnum))]
        /* 0x0 */ public NMSString0x10[] Rewards;
    }
}
