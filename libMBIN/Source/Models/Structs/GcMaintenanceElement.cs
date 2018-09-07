using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcMaintenanceElement : NMSTemplate       // size: 0x38
    {
        /* 0x00 */ public int ItemGroupOverride;        // not sure what type this is
        /* 0x04 */ public GcInventoryType Type;

        [NMS(Size = 0x10)]
        /* 0x08 */ public string Id;

        /* 0x18 */ public float MinRandAmount;
        /* 0x1C */ public float MaxRandAmount;
        /* 0x20 */ public float AmountEmptyTimePeriod;

		public enum UpdateTypeEnum { UpdatesAlways, UpdateOnlyWhenComplete, UpdateOnlyWhenNotComplete }
		public UpdateTypeEnum UpdateType;

        /* 0x28 */ public int DamagedAfterTimePeriodMin;
        /* 0x2C */ public int DamagedAfterTimePeriodMax;

        /* 0x30 */
		public enum DamageStatusEnum { Damaged, Repaired, Random }
		public DamageStatusEnum DamageStatus;
        /* 0x34 */
		public enum CompletionRequirementEnum { FullyChargedAndRepaired, AnyChargeAndRepaired, FullyRepaired, NotFullyCharged, EmptySlot, NoRequirement, UserInstalls, HasIngredients }
		public CompletionRequirementEnum CompletionRequirement;
    }
}
