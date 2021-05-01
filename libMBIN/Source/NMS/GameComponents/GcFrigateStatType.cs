using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x665B510E9A6208F3, NameHash = 0x5B21B72DF30D668C)]
    public class GcFrigateStatType : NMSTemplate
    {
        // size = 0xA
        public enum FrigateStatTypeEnum { Combat, Exploration, Mining, Diplomatic, FuelBurnRate, FuelCapacity,
            Speed, ExtraLoot, Repair, Invulnerable
        }
        public FrigateStatTypeEnum FrigateStatType;
    }
}