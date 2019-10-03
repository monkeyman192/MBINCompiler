namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x140, GUID = 0x3147BCDA0F39A1E0, NameHash = 0x16C7720D83E61CDB)]
    public class GcWeirdCreatureRewardList : NMSTemplate
    {
        [NMS(Size = 0x14)]
        public NMSString0x10[] Rewards;
    }
}
