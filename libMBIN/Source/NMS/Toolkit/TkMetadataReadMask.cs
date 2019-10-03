using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x4DEB11EC99BFE346, NameHash = 0x76BB9C78D7AE1C6B)]
    public class TkMetadataReadMask : NMSTemplate
    {
		public enum MetadataReadMaskEnum { Default, SaveWhenMultiplayerClient, SavePlayerPosition, SavePlayerInventory }
		public MetadataReadMaskEnum MetadataReadMask;
    }
}
