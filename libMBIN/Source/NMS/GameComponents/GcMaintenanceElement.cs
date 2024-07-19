using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1E9332A5DAD4EA09, NameHash = 0xA4087252)]
    public class GcMaintenanceElement : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x00 */ public NMSString0x20A LocatorOverride;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x10 Id;
        [NMS(Index = 6)]
        /* 0x30 */ public float AmountEmptyTimePeriod;
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
        [NMS(Index = 14)]
        /* 0x34 */ public CompletionRequirementEnum CompletionRequirement;
        [NMS(Index = 12)]
        /* 0x38 */ public int DamagedAfterTimePeriodMax;
        [NMS(Index = 11)]
        /* 0x3C */ public int DamagedAfterTimePeriodMin;
        // size: 0x3
        public enum DamageStatusEnum : uint {
            Damaged,
            Repaired,
            Random,
        }
        [NMS(Index = 13)]
        /* 0x40 */ public DamageStatusEnum DamageStatus;
        [NMS(Index = 0)]
        /* 0x44 */ public GcMaintenanceElementGroups ItemGroupOverride;
        [NMS(Index = 5)]
        /* 0x48 */ public int MaxCapacity;
        [NMS(Index = 4)]
        /* 0x4C */ public float MaxRandAmount;
        [NMS(Index = 3)]
        /* 0x50 */ public float MinRandAmount;
        [NMS(Index = 1)]
        /* 0x54 */ public GcInventoryType Type;
        // size: 0x3
        public enum UpdateTypeEnum : uint {
            UpdatesAlways,
            UpdateOnlyWhenComplete,
            UpdateOnlyWhenNotComplete,
        }
        [NMS(Index = 10)]
        /* 0x58 */ public UpdateTypeEnum UpdateType;
        [NMS(Index = 8)]
        /* 0x5C */ public bool BlockDiscardWhenAllowedForParent;
        [NMS(Index = 7)]
        /* 0x5D */ public bool HideWhenComplete;
    }
}
