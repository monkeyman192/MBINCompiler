using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE4C46129168D7C5, NameHash = 0xF90B35D6)]
    public class GcExoMechWeaponData : NMSTemplate
    {
        [NMS(Index = 2, Size = 0x5, EnumType = typeof(GcMechWeaponLocation.MechWeaponLocationEnum))]
        /* 0x00 */ public NMSString0x10[] MuzzleFlashDataID;
        [NMS(Index = 0)]
        /* 0x50 */ public List<GcMechWeaponLocation> LocationPriority;
        [NMS(Index = 3)]
        /* 0x60 */ public float AngleToleranceForArmAiming;
        [NMS(Index = 9)]
        /* 0x64 */ public float AttackAngle;
        [NMS(Index = 5)]
        /* 0x68 */ public float CooldownTimeMax;
        [NMS(Index = 4)]
        /* 0x6C */ public float CooldownTimeMin;
        [NMS(Index = 1)]
        /* 0x70 */ public float MaintainFireLocationMinTime;
        [NMS(Index = 8)]
        /* 0x74 */ public float MaxRange;
        [NMS(Index = 7)]
        /* 0x78 */ public float MinRange;
        [NMS(Index = 6)]
        /* 0x7C */ public float SelectionWeight;
    }
}
