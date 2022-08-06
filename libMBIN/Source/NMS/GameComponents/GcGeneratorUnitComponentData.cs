using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x32E6322B9724F800, NameHash = 0xE7D049A3A9D077A8)]
    public class GcGeneratorUnitComponentData : NMSTemplate
    {
        // size: 0x3
        public enum GeneratorUnitTypeEnum { MiningUnit, GasHarvester, SystemHoover }
		/* 0x000 */ public GeneratorUnitTypeEnum GeneratorUnitType;
        /* 0x004 */ public int ResourceMaintenanceSlotOverride;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x008 */ public NMSString0x10[] BiomeGasRewards;
        /* 0x110 */ public GcMaintenanceComponentData MaintenanceData;
    }
}
