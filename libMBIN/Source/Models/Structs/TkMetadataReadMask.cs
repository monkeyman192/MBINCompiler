namespace libMBIN.Models.Structs
{
    public class TkMetadataReadMask : NMSTemplate
    {
        public int MetadataReadMask;
        public string[] MetadataReadMaskValues()
        {
            return new[] { "Default", "SaveWhenMultiplayerClient", "SavePlayerPosition", "SavePlayerInventory" };
        }
    }
}
