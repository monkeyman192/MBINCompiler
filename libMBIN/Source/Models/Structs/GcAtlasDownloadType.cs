namespace libMBIN.Models.Structs
{
    public class GcAtlasDownloadType : NMSTemplate
    {
		public enum DownloadTypeEnum { Unknown, Discovery, Base, Message }
		public DownloadTypeEnum DownloadType;
    }
}
