using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF3E2FCC3F9D939EC, NameHash = 0x45C7860)]
    public class GcGeneratorUnitComponentData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        [NMS(Index = 2, Size = 0x11, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x430 */ public NMSString0x10[] BiomeGasRewards;
        // size: 0x4
        public enum GeneratorUnitTypeEnum : uint {
            MiningUnit,
            GasHarvester,
            SystemHoover,
            SeaHarvester,
        }
        [NMS(Index = 0)]
        /* 0x540 */ public GeneratorUnitTypeEnum GeneratorUnitType;
        [NMS(Index = 1)]
        /* 0x544 */ public int ResourceMaintenanceSlotOverride;
    }
}
