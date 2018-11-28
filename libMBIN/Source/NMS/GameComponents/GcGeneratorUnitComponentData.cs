using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x210, GUID = 0xBE898E2CA0F0F87)]
    public class GcGeneratorUnitComponentData : NMSTemplate
    {
		public enum GeneratorUnitTypeEnum { MiningUnit, GasHarvester }
		public GeneratorUnitTypeEnum GeneratorUnitType;
        /* 0x04 */ public int ResourceMaintenanceSlotOverride;
        [NMS( EnumType = typeof( GcBiomeType.BiomeEnum ) )]
        /* 0x08 */ public NMSString0x10[] BiomeGasRewards;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0xD8 */ public byte[] PaddingA8;
        /* 0xE0 */ public GcMaintenanceComponentData MaintenanceData;
    }
}
