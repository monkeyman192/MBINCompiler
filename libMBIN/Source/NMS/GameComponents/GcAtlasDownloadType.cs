namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x15B925A1205A944, NameHash = 0x584D91C2)]
    public class GcAtlasDownloadType : NMSTemplate
    {
        // size: 0x4
        public enum DownloadTypeEnum : uint {
            Unknown,
            Discovery,
            Base,
            Message,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DownloadTypeEnum DownloadType;
    }
}
