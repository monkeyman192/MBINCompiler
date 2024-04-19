using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3527C363F9E61B1F, NameHash = 0xB9BE8F8A6900C12E)]
    public class GcBaseLinkGridConnectionDependency : NMSTemplate
    {
        /* 0x00 */ public GcBaseLinkGridConnectionData Connection;
        // size: 0x5
        public enum DependentEffectEnum : uint {
            None,
            EnablesRate,
            DisablesRate,
            EnablesConnection,
            DisablesConnection,
        }
        /* 0x38 */ public DependentEffectEnum DependentEffect;
        /* 0x3C */ public int DependentRate;
        /* 0x40 */ public bool DisableWhenOffline;
        /* 0x41 */ public bool TransfersConnections;
    }
}
