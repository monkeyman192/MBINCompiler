namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC1A12C832D4AC62A, NameHash = 0x73783FC8636BAB3E)]
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
