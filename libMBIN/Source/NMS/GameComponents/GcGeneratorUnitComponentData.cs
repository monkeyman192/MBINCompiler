using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9E4D5667F61A1D4D, NameHash = 0xE7D049A3A9D077A8)]
    public class GcGeneratorUnitComponentData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        [NMS(Index = 2, Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x3E0 */ public NMSString0x10[] BiomeGasRewards;
        // size: 0x3
        public enum GeneratorUnitTypeEnum : uint {
            MiningUnit,
            GasHarvester,
            SystemHoover,
        }
        [NMS(Index = 0)]
        /* 0x4E0 */ public GeneratorUnitTypeEnum GeneratorUnitType;
        [NMS(Index = 1)]
        /* 0x4E4 */ public int ResourceMaintenanceSlotOverride;
    }
}
