using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkNoiseOffsetEnum : NMSTemplate
    {
        public int OffsetType;
        public string[] OffsetTypeValues()
        {
            return new[] { "Zero", "Base", "All", "SeaLevel" };
        }
    }
}
