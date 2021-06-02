using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0x57F3FDB2E908982F, NameHash = 0x79BDBA7746F3C796)]
    public class GcMaintenanceElement : NMSTemplate
    {
        /* 0x00 */ public GcMaintenanceElementGroups ItemGroupOverride;
        /* 0x04 */ public GcInventoryType Type;
        /* 0x08 */ public NMSString0x10 Id;
        /* 0x18 */ public float MinRandAmount;
        /* 0x1C */ public float MaxRandAmount;
        /* 0x20 */ public int MaxCapactiy;
        /* 0x24 */ public float AmountEmptyTimePeriod;
		public enum UpdateTypeEnum { UpdatesAlways, UpdateOnlyWhenComplete, UpdateOnlyWhenNotComplete }
		/* 0x28 */ public UpdateTypeEnum UpdateType;
        /* 0x2C */ public int DamagedAfterTimePeriodMin;
        /* 0x30 */ public int DamagedAfterTimePeriodMax;
		public enum DamageStatusEnum { Damaged, Repaired, Random }
		/* 0x34 */public DamageStatusEnum DamageStatus;
		public enum CompletionRequirementEnum { FullyChargedAndRepaired, AnyChargeAndRepaired, FullyRepaired, NotFullyCharged, EmptySlot, NoRequirement, UserInstalls, HasIngredients }
		/* 0x38 */ public CompletionRequirementEnum CompletionRequirement;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x3C */ public byte[] EndPadding;
    }
}
