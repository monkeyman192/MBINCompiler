using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x692A75E313548729, NameHash = 0x88C11D6208F25864)]
    public class GcParticleAction : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Effect;
        [NMS(Index = 3)]
        /* 0x10 */ public GcBroadcastLevel FindRange;
        [NMS(Index = 1)]
        /* 0x14 */ public NMSString0x20 Joint;
        [NMS(Index = 2)]
        /* 0x34 */ public bool Exact;
    }
}
