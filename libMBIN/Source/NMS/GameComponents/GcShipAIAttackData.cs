using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xD0, GUID = 0xDC9412B2F3921390, NameHash = 0xA9C402167AF9D69B)]
    public class GcShipAIAttackData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public float GunDispersionAngle;
        /* 0x14 */ public float GunFireRate;
        /* 0x18 */ public float LaserHealthPoint;
        /* 0x1C */ public float AttackWeaponRange;
        /* 0x20 */ public float AttackAngle;
        /* 0x24 */ public float AttackShootWaitTime;
        /* 0x28 */ public float AttackShootTimeMin;
        /* 0x2C */ public float AttackShootTimeMax;
        /* 0x30 */ public float AttackReadyTime;
        /* 0x34 */ public float AttackMaxTime;
        /* 0x38 */ public float AttackApproachOffset;
        /* 0x3C */ public float AttackApproachMinRange;
        /* 0x40 */ public float AttackApproachMaxRange;
        /* 0x44 */ public float AttackTooCloseRange;
        /* 0x48 */ public float AttackFlybyOffset;
        /* 0x4C */ public float AttackBoostTimeToRange;
        /* 0x50 */ public float AttackBoostRange;
        /* 0x54 */ public float AttackBoostAngle;
        /* 0x58 */ public float AttackTurnMultiplier;
        /* 0x5C */ public float AttackFacingAimReducer;
        /* 0x60 */ public float AttackMaxPlanetHeight;
        /* 0x64 */ public float AttackTurnMultiplierMax;
        /* 0x68 */ public float AttackTurnMaxMinTime;
        /* 0x6C */ public float AttackTurnMaxTimeRange;
        /* 0x70 */ public int NumHitsBeforeBail;
        /* 0x74 */ public int NumHitsBeforeReposition;
        /* 0x78 */ public float FleeBrake;
        /* 0x7C */ public float FleeBoost;
        /* 0x80 */ public float FleeBrakeTime;
        /* 0x84 */ public float FleeRepositionTime;
        /* 0x88 */ public float FleeRepositionAngleMin;
        /* 0x8C */ public float FleeRepositionAngleMax;
        /* 0x90 */ public float FleeUrgentBrake;
        /* 0x94 */ public float FleeUrgentBoost;
        /* 0x98 */ public float FleeUrgentBrakeTime;
        /* 0x9C */ public float FleeRepositionUrgentTime;
        /* 0xA0 */ public float FleeRepositionUrgentAngleMin;
        /* 0xA4 */ public float FleeRepositionUrgentAngleMax;
        /* 0xA8 */ public float FleeRange;
        /* 0xAC */ public float FleeMinTime;
        /* 0xB0 */ public float FleeMaxTime;
        /* 0xB4 */ public float FleeUrgentRange;
        /* 0xB8 */ public float AttackTargetMinRange;
        /* 0xBC */ public float AttackTargetMaxRange;
        /* 0xC0 */ public float AttackTargetOffsetMin;
        /* 0xC4 */ public float AttackTargetOffsetMax;
        /* 0xC8 */ public float AttackTargetSwitchTargetTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xCC */ public byte[] EndPadding;
    }
}
