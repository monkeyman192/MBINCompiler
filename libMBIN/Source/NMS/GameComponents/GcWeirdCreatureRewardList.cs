using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4960A84B32FFCEA2, NameHash = 0xE89F09DD)]
    public class GcWeirdCreatureRewardList : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x1C, EnumType = typeof(GcBiomeSubType.BiomeSubTypeEnum))]
        /* 0x0 */ public NMSString0x10[] Rewards;
    }
}
