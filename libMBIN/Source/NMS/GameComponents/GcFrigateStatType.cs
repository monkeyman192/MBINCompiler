using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x5756163EE10E2CBB, NameHash = 0x5B21B72DF30D668C)]
    public class GcFrigateStatType : NMSTemplate
    {
        // size: 0xB
        public enum FrigateStatTypeEnum { Combat, Exploration, Mining, Diplomatic, FuelBurnRate, FuelCapacity,
            Speed, ExtraLoot, Repair, Invulnerable, Stealth
        }
        public FrigateStatTypeEnum FrigateStatType;
    }
}