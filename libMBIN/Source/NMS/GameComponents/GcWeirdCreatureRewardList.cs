namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x3147BCDA0F39A1E0, NameHash = 0x16C7720D83E61CDB)]
    public class GcWeirdCreatureRewardList : NMSTemplate
    {
        [NMS(Size = 0x1B, EnumType = typeof(GcBiomeSubType.BiomeSubTypeEnum))]
        public NMSString0x10[] Rewards;
    }
}
