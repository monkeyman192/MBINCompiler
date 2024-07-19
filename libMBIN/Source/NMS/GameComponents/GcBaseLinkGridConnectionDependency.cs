using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7D80E159B5E345C, NameHash = 0x2A3874B9)]
    public class GcBaseLinkGridConnectionDependency : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcBaseLinkGridConnectionData Connection;
        // size: 0x5
        public enum DependentEffectEnum : uint {
            None,
            EnablesRate,
            DisablesRate,
            EnablesConnection,
            DisablesConnection,
        }
        [NMS(Index = 2)]
        /* 0x38 */ public DependentEffectEnum DependentEffect;
        [NMS(Index = 1)]
        /* 0x3C */ public int DependentRate;
        [NMS(Index = 3)]
        /* 0x40 */ public bool DisableWhenOffline;
        [NMS(Index = 4)]
        /* 0x41 */ public bool TransfersConnections;
    }
}
