namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xE804ECE24A11E442, NameHash = 0xE683DEE43F8D7719)]
    public class GcAtlasShared : NMSTemplate
    {
        // TODO: there is something fishy going on here...
        public ulong ClientUserdata;
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] EndPadding;
    }
}
