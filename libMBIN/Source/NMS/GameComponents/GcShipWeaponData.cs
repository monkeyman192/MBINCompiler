using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3F08F95FEEA7B4F3, NameHash = 0x73BA1311CF8E1962)]
    public class GcShipWeaponData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Projectile;
        /* 0x10 */ public GcStatsTypes Stat;
        /* 0x14 */ public bool IsProjectile;
        /* 0x18 */ public NMSString0x10 Reticle;
        /* 0x28 */ public float AutoAimAngle;
        /* 0x2C */ public float AutoAimExtraAngle;
        /* 0x30 */ public bool ShowOverheatSwitch;
        /* 0x34 */ public float OverheatCoolTime;
        /* 0x38 */ public float CoolRate;
        /* 0x3C */ public GcRemoteWeapons RemoteType;
    }
}
