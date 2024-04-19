namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xEF8549DC9D356FDC, NameHash = 0x56A47F95DD76DC72)]
    public class TkEmitFromParticleInfo : NMSTemplate
    {
        // size: 0x2
        public enum EmissionRateTypeEnum : uint {
            PerParticle,
            Distance,
        }
        /* 0x0 */ public EmissionRateTypeEnum EmissionRateType;
        /* 0x4 */ public int OtherEmitterIndex;
    }
}
