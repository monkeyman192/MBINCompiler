using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBA11D21C1FA51FAA, NameHash = 0x8A1BFCC09E50150B)]
    public class GcPersistedStatData : NMSTemplate
    {
        public NMSString0x10 GroupId;
        public NMSString0x10 StatId;
    }
}
