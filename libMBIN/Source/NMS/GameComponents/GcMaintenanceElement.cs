using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x75750D559E7D12C3, NameHash = 0x79BDBA7746F3C796)]
    public class GcMaintenanceElement : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 6)]
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
        [NMS(Index = 13)]
        /* 0x14 */ public CompletionRequirementEnum CompletionRequirement;
        [NMS(Index = 11)]
        /* 0x18 */ public int DamagedAfterTimePeriodMax;
        [NMS(Index = 10)]
        /* 0x1C */ public int DamagedAfterTimePeriodMin;
        // size: 0x3
        public enum DamageStatusEnum : uint {
            Damaged,
            Repaired,
            Random,
        }
        [NMS(Index = 12)]
        /* 0x20 */ public DamageStatusEnum DamageStatus;
        [NMS(Index = 0)]
        /* 0x24 */ public GcMaintenanceElementGroups ItemGroupOverride;
        [NMS(Index = 5)]
        /* 0x28 */ public int MaxCapacity;
        [NMS(Index = 4)]
        /* 0x2C */ public float MaxRandAmount;
        [NMS(Index = 3)]
        /* 0x30 */ public float MinRandAmount;
        [NMS(Index = 1)]
        /* 0x34 */ public GcInventoryType Type;
        // size: 0x3
        public enum UpdateTypeEnum : uint {
            UpdatesAlways,
            UpdateOnlyWhenComplete,
            UpdateOnlyWhenNotComplete,
        }
        [NMS(Index = 9)]
        /* 0x38 */ public UpdateTypeEnum UpdateType;
        [NMS(Index = 8)]
        /* 0x3C */ public bool BlockDiscardWhenAllowedForParent;
        [NMS(Index = 7)]
        /* 0x3D */ public bool HideWhenComplete;
    }
}
