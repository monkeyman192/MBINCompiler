using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x692A75E313548729, NameHash = 0x88C11D6208F25864)]
    public class GcParticleAction : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Effect;
        /* 0x10 */ public GcBroadcastLevel FindRange;
        /* 0x14 */ public NMSString0x20 Joint;
        /* 0x34 */ public bool Exact;
    }
}
