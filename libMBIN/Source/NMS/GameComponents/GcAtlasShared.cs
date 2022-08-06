namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE804ECE24A11E442, NameHash = 0xE683DEE43F8D7719)]
    public class GcAtlasShared : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
    }
}
