using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x705C25A0E3BC6165, NameHash = 0xC42B2790FC61E0A9)]
    public class GcDroneData : NMSTemplate
    {
        [NMS(Index = 36)]
        /* 0x000 */ public Colour EyeColourAlert;
        [NMS(Index = 38)]
        /* 0x010 */ public Colour EyeColourPatrol;
        [NMS(Index = 37)]
        /* 0x020 */ public Colour EyeColourSearch;
        [NMS(Index = 39)]
        /* 0x030 */ public NMSString0x10 DamageEffect;
        [NMS(Index = 52)]
        /* 0x040 */ public GcSentinelResource CoverResource;
        [NMS(Index = 1)]
        /* 0x0D4 */ public GcDroneControlData Attack;
        [NMS(Index = 8)]
        /* 0x104 */ public GcDroneControlData Friendly;
        [NMS(Index = 9)]
        /* 0x134 */ public GcDroneControlData FriendlyFast;
        [NMS(Index = 0)]
        /* 0x164 */ public GcDroneControlData Patrol;
        [NMS(Index = 4)]
        /* 0x194 */ public GcDroneControlData Repair;
        [NMS(Index = 3)]
        /* 0x1C4 */ public GcDroneControlData Scan;
        [NMS(Index = 2)]
        /* 0x1F4 */ public GcDroneControlData Search;
        [NMS(Index = 7)]
        /* 0x224 */ public GcDroneControlData Stun;
        [NMS(Index = 5)]
        /* 0x254 */ public GcDroneControlData Summon;
        [NMS(Index = 6)]
        /* 0x284 */ public GcDroneControlData ToCover;
        [NMS(Index = 29)]
        /* 0x2B4 */ public float AttackActivateTime;
        [NMS(Index = 35)]
        /* 0x2B8 */ public float AttackAlertFailTime;
        [NMS(Index = 27)]
        /* 0x2BC */ public float AttackAngle;
        [NMS(Index = 30)]
        /* 0x2C0 */ public float AttackBobAmount;
        [NMS(Index = 31)]
        /* 0x2C4 */ public float AttackBobRotation;
        [NMS(Index = 34)]
        /* 0x2C8 */ public float AttackMaxDistanceFromAlert;
        [NMS(Index = 28)]
        /* 0x2CC */ public float AttackMinSpeed;
        [NMS(Index = 33)]
        /* 0x2D0 */ public float AttackMoveAngle;
        [NMS(Index = 26)]
        /* 0x2D4 */ public float AttackMoveLookDistanceMin;
        [NMS(Index = 25)]
        /* 0x2D8 */ public float AttackMoveLookDistanceRange;
        [NMS(Index = 32)]
        /* 0x2DC */ public float AttackMoveMinChoiceTime;
        [NMS(Index = 10)]
        /* 0x2E0 */ public float CollisionAvoidOffset;
        [NMS(Index = 44)]
        /* 0x2E4 */ public float CoverPlacementActivateTime;
        [NMS(Index = 45)]
        /* 0x2E8 */ public float CoverPlacementActivateTimeMaxRandomExtra;
        [NMS(Index = 46)]
        /* 0x2EC */ public float CoverPlacementCooldownTime;
        [NMS(Index = 51)]
        /* 0x2F0 */ public int CoverPlacementMaxActiveCover;
        [NMS(Index = 49)]
        /* 0x2F4 */ public float CoverPlacementMaxDistanceFromSelf;
        [NMS(Index = 48)]
        /* 0x2F8 */ public float CoverPlacementMinDistanceFromSelf;
        [NMS(Index = 47)]
        /* 0x2FC */ public float CoverPlacementMinDistanceFromTarget;
        [NMS(Index = 50)]
        /* 0x300 */ public float CoverPlacementUpOffset;
        [NMS(Index = 40)]
        /* 0x304 */ public float DamageEffectHealthPercentThreshold;
        [NMS(Index = 24)]
        /* 0x308 */ public float DroneAlertTime;
        [NMS(Index = 12)]
        /* 0x30C */ public float DronePatrolDistanceMax;
        [NMS(Index = 11)]
        /* 0x310 */ public float DronePatrolDistanceMin;
        [NMS(Index = 23)]
        /* 0x314 */ public int DronePatrolHonkProbability;
        [NMS(Index = 21)]
        /* 0x318 */ public float DronePatrolHonkRadius;
        [NMS(Index = 22)]
        /* 0x31C */ public float DronePatrolHonkTime;
        [NMS(Index = 15)]
        /* 0x320 */ public float DronePatrolInspectDistanceMax;
        [NMS(Index = 14)]
        /* 0x324 */ public float DronePatrolInspectDistanceMin;
        [NMS(Index = 18)]
        /* 0x328 */ public float DronePatrolInspectRadius;
        [NMS(Index = 17)]
        /* 0x32C */ public float DronePatrolInspectSwitchTime;
        [NMS(Index = 16)]
        /* 0x330 */ public float DronePatrolInspectTargetTime;
        [NMS(Index = 19)]
        /* 0x334 */ public float DronePatrolRepelDistance;
        [NMS(Index = 20)]
        /* 0x338 */ public float DronePatrolRepelStrength;
        [NMS(Index = 13)]
        /* 0x33C */ public float DronePatrolTargetDistance;
        [NMS(Index = 59)]
        /* 0x340 */ public float DroneScanPlayerTime;
        [NMS(Index = 56)]
        /* 0x344 */ public float DroneSearchCriminalScanRadius;
        [NMS(Index = 58)]
        /* 0x348 */ public float DroneSearchCriminalScanRadiusInShip;
        [NMS(Index = 57)]
        /* 0x34C */ public float DroneSearchCriminalScanRadiusWanted;
        [NMS(Index = 55)]
        /* 0x350 */ public float DroneSearchPauseTime;
        [NMS(Index = 54)]
        /* 0x354 */ public float DroneSearchRadius;
        [NMS(Index = 53)]
        /* 0x358 */ public float DroneSearchTime;
        [NMS(Index = 71)]
        /* 0x35C */ public float EngineDirAngleMax;
        [NMS(Index = 70)]
        /* 0x360 */ public float EngineDirSpeedMin;
        [NMS(Index = 69)]
        /* 0x364 */ public float EyeAngleMax;
        [NMS(Index = 64)]
        /* 0x368 */ public float EyeFocusTime;
        [NMS(Index = 66)]
        /* 0x36C */ public int EyeNumRandomsMax;
        [NMS(Index = 65)]
        /* 0x370 */ public int EyeNumRandomsMin;
        [NMS(Index = 63)]
        /* 0x374 */ public float EyeOffset;
        [NMS(Index = 68)]
        /* 0x378 */ public float EyeTimeMax;
        [NMS(Index = 67)]
        /* 0x37C */ public float EyeTimeMin;
        [NMS(Index = 41)]
        /* 0x380 */ public float HideBehindCoverHealthPercentThreshold;
        [NMS(Index = 42)]
        /* 0x384 */ public float HideBehindCoverSearchRadius;
        [NMS(Index = 60)]
        /* 0x388 */ public float LeanAmount;
        [NMS(Index = 61)]
        /* 0x38C */ public float LeanSpeedMin;
        [NMS(Index = 62)]
        /* 0x390 */ public float LeanSpeedRange;
        [NMS(Index = 43)]
        /* 0x394 */ public bool EnableCoverPlacement;
    }
}
