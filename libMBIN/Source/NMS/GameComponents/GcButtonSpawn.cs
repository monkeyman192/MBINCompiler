using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3177C1DE30741198, NameHash = 0x7F9FCEDE7E2CBFC0)]
    public class GcButtonSpawn : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public GcButtonSpawnOffset Offset;
        [NMS(Index = 0)]
        /* 0x20 */ public TkInputEnum Button;
        // size: 0x5
        public enum EventEnum : uint {
            None,
            Pirates,
            Police,
            Traders,
            Walker,
        }
        [NMS(Index = 1)]
        /* 0x24 */ public EventEnum Event;
    }
}
