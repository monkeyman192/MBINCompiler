using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcAtlasDownloadType : NMSTemplate
    {
        public int DownloadType;
        public string[] DownloadTypeValues()
        {
            return new[]
            {
                "Unknown", "Discovery", "Base", "Message"
            };
        }
    }
}
