namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE631E6FFCC918379, NameHash = 0xA9C402167AF9D69B)]
    public class GcShipAIAttackData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public float AttackAngle;
        /* 0x14 */ public float AttackApproachMaxRange;
        /* 0x18 */ public float AttackApproachMinRange;
        /* 0x1C */ public float AttackApproachOffset;
        /* 0x20 */ public float AttackBoostAngle;
        /* 0x24 */ public float AttackBoostRange;
        /* 0x28 */ public float AttackBoostTimeToRange;
        /* 0x2C */ public float AttackFlybyOffset;
        /* 0x30 */ public float AttackMaxPlanetHeight;
        /* 0x34 */ public float AttackMaxTime;
        /* 0x38 */ public float AttackReadyTime;
        /* 0x3C */ public float AttackShootTimeMax;
        /* 0x40 */ public float AttackShootTimeMin;
        /* 0x44 */ public float AttackShootWaitTime;
        /* 0x48 */ public float AttackTargetMaxRange;
        /* 0x4C */ public float AttackTargetMinRange;
        /* 0x50 */ public float AttackTargetOffsetMax;
        /* 0x54 */ public float AttackTargetOffsetMin;
        /* 0x58 */ public float AttackTargetSwitchTargetTime;
        /* 0x5C */ public float AttackTooCloseRange;
        /* 0x60 */ public float AttackTurnMaxMinTime;
        /* 0x64 */ public float AttackTurnMaxTimeRange;
        /* 0x68 */ public float AttackTurnMultiplier;
        /* 0x6C */ public float AttackTurnMultiplierMax;
        /* 0x70 */ public float AttackWeaponRange;
        /* 0x74 */ public float FleeBoost;
        /* 0x78 */ public float FleeBrake;
        /* 0x7C */ public float FleeBrakeTime;
        /* 0x80 */ public float FleeMaxTime;
        /* 0x84 */ public float FleeMinTime;
        /* 0x88 */ public float FleeRange;
        /* 0x8C */ public float FleeRepositionAngleMax;
        /* 0x90 */ public float FleeRepositionAngleMin;
        /* 0x94 */ public float FleeRepositionTime;
        /* 0x98 */ public float FleeRepositionUrgentAngleMax;
        /* 0x9C */ public float FleeRepositionUrgentAngleMin;
        /* 0xA0 */ public float FleeRepositionUrgentTime;
        /* 0xA4 */ public float FleeUrgentBoost;
        /* 0xA8 */ public float FleeUrgentBrake;
        /* 0xAC */ public float FleeUrgentBrakeTime;
        /* 0xB0 */ public float FleeUrgentRange;
        /* 0xB4 */ public float GunDispersionAngle;
        /* 0xB8 */ public float GunFireRate;
        /* 0xBC */ public float LaserHealthPoint;
        /* 0xC0 */ public int NumHitsBeforeBail;
        /* 0xC4 */ public int NumHitsBeforeReposition;
        /* 0xC8 */ public float PlanetFleeHeightExtra;
    }
}
