using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC0, Alignment = 0x8, GUID = 0xEB2BD58DCACBE35A, NameHash = 0x9166CF1D0ED63522)]
    public class GcMissionSequencePirates : NMSTemplate
    {
        /* 0x00 */ public bool ScanCargo;
        /* 0x04 */ public int NumSquads;
        /* 0x08 */ public NMSString0x10 AttackDefinition;
        /* 0x18 */ public NMSString0x20 RewardMessageOverride;
        /* 0x38 */ public bool Silent;
        /* 0x3C */ public float DistanceOverride;
        /* 0x40 */ public NMSString0x80 DebugText;
    }
}
