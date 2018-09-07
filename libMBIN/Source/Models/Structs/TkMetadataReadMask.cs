namespace libMBIN.Models.Structs
{
    public class TkMetadataReadMask : NMSTemplate
    {
		public enum MetadataReadMaskEnum { Default, SaveWhenMultiplayerClient, SavePlayerPosition, SavePlayerInventory }
		public MetadataReadMaskEnum MetadataReadMask;
    }
}
