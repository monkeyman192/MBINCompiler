using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x899443B21C9CDCCE, NameHash = 0x1C08FB02D59766DB)]
    public class GcBaseSnapState : NMSTemplate
    {
        // size: 0x2
        public enum SnapStateEnum { IsSnapped, NotSnapped }
        public SnapStateEnum SnapState;
    }
}
