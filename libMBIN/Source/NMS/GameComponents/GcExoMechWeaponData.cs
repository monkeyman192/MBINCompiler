using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x38943C543D2DBBFD, NameHash = 0xAB111A88D43A92B4)]
    public class GcExoMechWeaponData : NMSTemplate
    {
        [NMS(Index = 2, Size = 0x4, EnumType = typeof(GcMechWeaponLocation.MechWeaponLocationEnum))]
        /* 0x00 */ public NMSString0x10[] MuzzleFlashDataID;
        [NMS(Index = 0)]
        /* 0x40 */ public List<GcMechWeaponLocation> LocationPriority;
        [NMS(Index = 3)]
        /* 0x50 */ public float AngleToleranceForArmAiming;
        [NMS(Index = 9)]
        /* 0x54 */ public float AttackAngle;
        [NMS(Index = 5)]
        /* 0x58 */ public float CooldownTimeMax;
        [NMS(Index = 4)]
        /* 0x5C */ public float CooldownTimeMin;
        [NMS(Index = 1)]
        /* 0x60 */ public float MaintainFireLocationMinTime;
        [NMS(Index = 8)]
        /* 0x64 */ public float MaxRange;
        [NMS(Index = 7)]
        /* 0x68 */ public float MinRange;
        [NMS(Index = 6)]
        /* 0x6C */ public float SelectionWeight;
    }
}
