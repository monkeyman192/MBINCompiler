using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0x130BC4FD8A626302, NameHash = 0x73BA1311CF8E1962)]
    public class GcShipWeaponData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Projectile;
        /* 0x10 */ public GcStatsTypes Stat;
        /* 0x14 */ public bool IsProjectile;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x15 */ public byte[] Padding15;
        /* 0x18 */ public NMSString0x10 Reticle;
        /* 0x28 */ public float AutoAimAngle;
        /* 0x2C */ public float AutoAimExtraAngle;
        /* 0x30 */ public bool ShowOverheatSwitch;
        /* 0x34 */ public float OverheatCoolTime;
        /* 0x38 */ public float CoolRate;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
