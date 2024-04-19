using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x34E79E36B5462BA, NameHash = 0xAB111A88D43A92B4)]
    public class GcExoMechWeaponData : NMSTemplate
    {
        [NMS(Size = 0x4, EnumType = typeof(GcMechWeaponLocation.MechWeaponLocationEnum))]
        /* 0x00 */ public NMSString0x10[] MuzzleFlashDataID;
        /* 0x40 */ public List<GcMechWeaponLocation> LocationPriority;
        /* 0x50 */ public float AngleToleranceForArmAiming;
        /* 0x54 */ public float AttackAngle;
        /* 0x58 */ public float CooldownTimeMax;
        /* 0x5C */ public float CooldownTimeMin;
        /* 0x60 */ public float MaintainFireLocationMinTime;
        /* 0x64 */ public float MaxRange;
        /* 0x68 */ public float MinRange;
        /* 0x6C */ public float SelectionWeight;
    }
}
