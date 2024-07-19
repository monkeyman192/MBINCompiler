namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5117881284BBB64D, NameHash = 0x86999DB6)]
    public class GcShipAIAttackData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 5)]
        /* 0x10 */ public float AttackAngle;
        [NMS(Index = 13)]
        /* 0x14 */ public float AttackApproachMaxRange;
        [NMS(Index = 12)]
        /* 0x18 */ public float AttackApproachMinRange;
        [NMS(Index = 11)]
        /* 0x1C */ public float AttackApproachOffset;
        [NMS(Index = 18)]
        /* 0x20 */ public float AttackBoostAngle;
        [NMS(Index = 17)]
        /* 0x24 */ public float AttackBoostRange;
        [NMS(Index = 16)]
        /* 0x28 */ public float AttackBoostTimeToRange;
        [NMS(Index = 15)]
        /* 0x2C */ public float AttackFlybyOffset;
        [NMS(Index = 20)]
        /* 0x30 */ public float AttackMaxPlanetHeight;
        [NMS(Index = 10)]
        /* 0x34 */ public float AttackMaxTime;
        [NMS(Index = 9)]
        /* 0x38 */ public float AttackReadyTime;
        [NMS(Index = 8)]
        /* 0x3C */ public float AttackShootTimeMax;
        [NMS(Index = 7)]
        /* 0x40 */ public float AttackShootTimeMin;
        [NMS(Index = 6)]
        /* 0x44 */ public float AttackShootWaitTime;
        [NMS(Index = 44)]
        /* 0x48 */ public float AttackTargetMaxRange;
        [NMS(Index = 43)]
        /* 0x4C */ public float AttackTargetMinRange;
        [NMS(Index = 46)]
        /* 0x50 */ public float AttackTargetOffsetMax;
        [NMS(Index = 45)]
        /* 0x54 */ public float AttackTargetOffsetMin;
        [NMS(Index = 47)]
        /* 0x58 */ public float AttackTargetSwitchTargetTime;
        [NMS(Index = 14)]
        /* 0x5C */ public float AttackTooCloseRange;
        [NMS(Index = 22)]
        /* 0x60 */ public float AttackTurnMaxMinTime;
        [NMS(Index = 23)]
        /* 0x64 */ public float AttackTurnMaxTimeRange;
        [NMS(Index = 19)]
        /* 0x68 */ public float AttackTurnMultiplier;
        [NMS(Index = 21)]
        /* 0x6C */ public float AttackTurnMultiplierMax;
        [NMS(Index = 4)]
        /* 0x70 */ public float AttackWeaponRange;
        [NMS(Index = 27)]
        /* 0x74 */ public float FleeBoost;
        [NMS(Index = 26)]
        /* 0x78 */ public float FleeBrake;
        [NMS(Index = 28)]
        /* 0x7C */ public float FleeBrakeTime;
        [NMS(Index = 40)]
        /* 0x80 */ public float FleeMaxTime;
        [NMS(Index = 39)]
        /* 0x84 */ public float FleeMinTime;
        [NMS(Index = 38)]
        /* 0x88 */ public float FleeRange;
        [NMS(Index = 31)]
        /* 0x8C */ public float FleeRepositionAngleMax;
        [NMS(Index = 30)]
        /* 0x90 */ public float FleeRepositionAngleMin;
        [NMS(Index = 29)]
        /* 0x94 */ public float FleeRepositionTime;
        [NMS(Index = 37)]
        /* 0x98 */ public float FleeRepositionUrgentAngleMax;
        [NMS(Index = 36)]
        /* 0x9C */ public float FleeRepositionUrgentAngleMin;
        [NMS(Index = 35)]
        /* 0xA0 */ public float FleeRepositionUrgentTime;
        [NMS(Index = 33)]
        /* 0xA4 */ public float FleeUrgentBoost;
        [NMS(Index = 32)]
        /* 0xA8 */ public float FleeUrgentBrake;
        [NMS(Index = 34)]
        /* 0xAC */ public float FleeUrgentBrakeTime;
        [NMS(Index = 41)]
        /* 0xB0 */ public float FleeUrgentRange;
        [NMS(Index = 1)]
        /* 0xB4 */ public float GunDispersionAngle;
        [NMS(Index = 2)]
        /* 0xB8 */ public float GunFireRate;
        [NMS(Index = 3)]
        /* 0xBC */ public float LaserHealthPoint;
        [NMS(Index = 24)]
        /* 0xC0 */ public int NumHitsBeforeBail;
        [NMS(Index = 25)]
        /* 0xC4 */ public int NumHitsBeforeReposition;
        [NMS(Index = 42)]
        /* 0xC8 */ public float PlanetFleeHeightExtra;
    }
}
