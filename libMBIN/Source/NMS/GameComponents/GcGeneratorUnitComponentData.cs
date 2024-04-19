using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x338B67A39ADC360B, NameHash = 0xE7D049A3A9D077A8)]
    public class GcGeneratorUnitComponentData : NMSTemplate
    {
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x3E0 */ public NMSString0x10[] BiomeGasRewards;
        // size: 0x3
        public enum GeneratorUnitTypeEnum : uint {
            MiningUnit,
            GasHarvester,
            SystemHoover,
        }
        /* 0x4E0 */ public GeneratorUnitTypeEnum GeneratorUnitType;
        /* 0x4E4 */ public int ResourceMaintenanceSlotOverride;
    }
}
