using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCC63EE3FF18D05FE, NameHash = 0xAF90A56B0E99C0CB)]
    public class GcFiendCrime : NMSTemplate
    {
        // size: 0x9
        public enum FiendCrimeEnum { None, EggDamaged, EggDestroyed, EggCollected, UnderwaterPropDamaged, UnderwaterPropCollected,
            RockTransform, GroundPropDamage, ShotWorm
        }
        /* 0x0 */ public FiendCrimeEnum FiendCrime;
    }
}
