using System;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x29BF52BAA2C7EB9C, NameHash = 0x6CA73DFD)]
    public class GcCreatureParticleEffectTrigger : NMSTemplate
    {
        // size: 0x7
        [Flags]
        public enum CreatureParticleEffectTriggerEnum : uint {
            None = 0x0,
            Spawn = 0x1,
            Despawn = 0x2,
            Death = 0x4,
            Ragdoll = 0x8,
            Appear = 0x10,
            Disappear = 0x20,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CreatureParticleEffectTriggerEnum CreatureParticleEffectTrigger;
    }
}
