namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x210)]
    public class GcGeneratorUnitComponentData : NMSTemplate
    {
		public enum GeneratorUnitTypeEnum { MiningUnit, GasHarvester }
		public GeneratorUnitTypeEnum GeneratorUnitType;
        /* 0x04 */ public int ResourceMaintenanceSlotOverride;
        [NMS(Size = 0xD, EnumValue = new string[] { "Lush", "Toxic", "Scorched", "Radioactive", "Frozen", "Barren", "Dead", "Weird", "Red", "Green", "Blue", "Test", "All" })]
        /* 0x08 */ public NMSString0x10[] BiomeGasRewards;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0xD8 */ public byte[] PaddingA8;
        /* 0xE0 */ public GcMaintenanceComponentData MaintenanceData;
    }
}
