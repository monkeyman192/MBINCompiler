using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA799B5F08F3C57FF, NameHash = 0x28FFDDA9)]
    public class GcProjectileImpactData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Effect;
        [NMS(Index = 1)]
        /* 0x10 */ public GcProjectileImpactType Impact;
        // size: 0x3
        public enum ImpactAlignmentEnum : uint {
            ImpactNormal,
            ImpactReflected,
            GravityUp,
        }
        [NMS(Index = 2)]
        /* 0x14 */ public ImpactAlignmentEnum ImpactAlignment;
        // size: 0x2
        public enum ImpactAttachmentEnum : uint {
            World,
            HitBody,
        }
        [NMS(Index = 3)]
        /* 0x18 */ public ImpactAttachmentEnum ImpactAttachment;
    }
}
