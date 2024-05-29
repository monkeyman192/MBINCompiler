using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1CF33303F5087894, NameHash = 0xE7D049A3A9D077A8)]
    public class GcGeneratorUnitComponentData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        [NMS(Index = 2, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x3F0 */ public NMSString0x10[] BiomeGasRewards;
        // size: 0x3
        public enum GeneratorUnitTypeEnum : uint {
            MiningUnit,
            GasHarvester,
            SystemHoover,
        }
        [NMS(Index = 0)]
        /* 0x4F0 */ public GeneratorUnitTypeEnum GeneratorUnitType;
        [NMS(Index = 1)]
        /* 0x4F4 */ public int ResourceMaintenanceSlotOverride;
    }
}
