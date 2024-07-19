using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC0C84039793B335C, NameHash = 0xCB8A0459)]
    public class TkParticleBurstData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkEmitterFloatProperty BurstAmount;
        [NMS(Index = 1)]
        /* 0x38 */ public TkEmitterFloatProperty BurstInterval;
        [NMS(Index = 2)]
        /* 0x70 */ public int LoopCount;
    }
}
