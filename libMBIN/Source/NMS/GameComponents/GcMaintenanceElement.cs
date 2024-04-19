using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x75750D559E7D12C3, NameHash = 0x79BDBA7746F3C796)]
    public class GcMaintenanceElement : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public float AmountEmptyTimePeriod;
        // size: 0x9
        public enum CompletionRequirementEnum : uint {
            FullyChargedAndRepaired,
            AnyChargeAndRepaired,
            FullyRepaired,
            NotFullyCharged,
            EmptySlot,
            NoRequirement,
            UserInstalls,
            HasIngredients,
            GroupInstall,
        }
        /* 0x14 */ public CompletionRequirementEnum CompletionRequirement;
        /* 0x18 */ public int DamagedAfterTimePeriodMax;
        /* 0x1C */ public int DamagedAfterTimePeriodMin;
        // size: 0x3
        public enum DamageStatusEnum : uint {
            Damaged,
            Repaired,
            Random,
        }
        /* 0x20 */ public DamageStatusEnum DamageStatus;
        /* 0x24 */ public GcMaintenanceElementGroups ItemGroupOverride;
        /* 0x28 */ public int MaxCapacity;
        /* 0x2C */ public float MaxRandAmount;
        /* 0x30 */ public float MinRandAmount;
        /* 0x34 */ public GcInventoryType Type;
        // size: 0x3
        public enum UpdateTypeEnum : uint {
            UpdatesAlways,
            UpdateOnlyWhenComplete,
            UpdateOnlyWhenNotComplete,
        }
        /* 0x38 */ public UpdateTypeEnum UpdateType;
        /* 0x3C */ public bool BlockDiscardWhenAllowedForParent;
        /* 0x3D */ public bool HideWhenComplete;
    }
}
