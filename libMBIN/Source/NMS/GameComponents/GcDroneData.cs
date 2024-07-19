using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xABBFC2B52C3AA227, NameHash = 0x5516BAF9)]
    public class GcDroneData : NMSTemplate
    {
        [NMS(Index = 36)]
        /* 0x000 */ public Colour EyeColourAlert;
        [NMS(Index = 38)]
        /* 0x010 */ public Colour EyeColourPatrol;
        [NMS(Index = 37)]
        /* 0x020 */ public Colour EyeColourSearch;
        [NMS(Index = 52)]
        /* 0x030 */ public GcSentinelResource CoverResource;
        [NMS(Index = 39)]
        /* 0x058 */ public NMSString0x10 DamageEffect;
        [NMS(Index = 1)]
        /* 0x068 */ public GcDroneControlData Attack;
        [NMS(Index = 8)]
        /* 0x098 */ public GcDroneControlData Friendly;
        [NMS(Index = 9)]
        /* 0x0C8 */ public GcDroneControlData FriendlyFast;
        [NMS(Index = 0)]
        /* 0x0F8 */ public GcDroneControlData Patrol;
        [NMS(Index = 4)]
        /* 0x128 */ public GcDroneControlData Repair;
        [NMS(Index = 3)]
        /* 0x158 */ public GcDroneControlData Scan;
        [NMS(Index = 2)]
        /* 0x188 */ public GcDroneControlData Search;
        [NMS(Index = 7)]
        /* 0x1B8 */ public GcDroneControlData Stun;
        [NMS(Index = 5)]
        /* 0x1E8 */ public GcDroneControlData Summon;
        [NMS(Index = 6)]
        /* 0x218 */ public GcDroneControlData ToCover;
        [NMS(Index = 29)]
        /* 0x248 */ public float AttackActivateTime;
        [NMS(Index = 35)]
        /* 0x24C */ public float AttackAlertFailTime;
        [NMS(Index = 27)]
        /* 0x250 */ public float AttackAngle;
        [NMS(Index = 30)]
        /* 0x254 */ public float AttackBobAmount;
        [NMS(Index = 31)]
        /* 0x258 */ public float AttackBobRotation;
        [NMS(Index = 34)]
        /* 0x25C */ public float AttackMaxDistanceFromAlert;
        [NMS(Index = 28)]
        /* 0x260 */ public float AttackMinSpeed;
        [NMS(Index = 33)]
        /* 0x264 */ public float AttackMoveAngle;
        [NMS(Index = 26)]
        /* 0x268 */ public float AttackMoveLookDistanceMin;
        [NMS(Index = 25)]
        /* 0x26C */ public float AttackMoveLookDistanceRange;
        [NMS(Index = 32)]
        /* 0x270 */ public float AttackMoveMinChoiceTime;
        [NMS(Index = 10)]
        /* 0x274 */ public float CollisionAvoidOffset;
        [NMS(Index = 44)]
        /* 0x278 */ public float CoverPlacementActivateTime;
        [NMS(Index = 45)]
        /* 0x27C */ public float CoverPlacementActivateTimeMaxRandomExtra;
        [NMS(Index = 46)]
        /* 0x280 */ public float CoverPlacementCooldownTime;
        [NMS(Index = 51)]
        /* 0x284 */ public int CoverPlacementMaxActiveCover;
        [NMS(Index = 49)]
        /* 0x288 */ public float CoverPlacementMaxDistanceFromSelf;
        [NMS(Index = 48)]
        /* 0x28C */ public float CoverPlacementMinDistanceFromSelf;
        [NMS(Index = 47)]
        /* 0x290 */ public float CoverPlacementMinDistanceFromTarget;
        [NMS(Index = 50)]
        /* 0x294 */ public float CoverPlacementUpOffset;
        [NMS(Index = 40)]
        /* 0x298 */ public float DamageEffectHealthPercentThreshold;
        [NMS(Index = 24)]
        /* 0x29C */ public float DroneAlertTime;
        [NMS(Index = 12)]
        /* 0x2A0 */ public float DronePatrolDistanceMax;
        [NMS(Index = 11)]
        /* 0x2A4 */ public float DronePatrolDistanceMin;
        [NMS(Index = 23)]
        /* 0x2A8 */ public int DronePatrolHonkProbability;
        [NMS(Index = 21)]
        /* 0x2AC */ public float DronePatrolHonkRadius;
        [NMS(Index = 22)]
        /* 0x2B0 */ public float DronePatrolHonkTime;
        [NMS(Index = 15)]
        /* 0x2B4 */ public float DronePatrolInspectDistanceMax;
        [NMS(Index = 14)]
        /* 0x2B8 */ public float DronePatrolInspectDistanceMin;
        [NMS(Index = 18)]
        /* 0x2BC */ public float DronePatrolInspectRadius;
        [NMS(Index = 17)]
        /* 0x2C0 */ public float DronePatrolInspectSwitchTime;
        [NMS(Index = 16)]
        /* 0x2C4 */ public float DronePatrolInspectTargetTime;
        [NMS(Index = 19)]
        /* 0x2C8 */ public float DronePatrolRepelDistance;
        [NMS(Index = 20)]
        /* 0x2CC */ public float DronePatrolRepelStrength;
        [NMS(Index = 13)]
        /* 0x2D0 */ public float DronePatrolTargetDistance;
        [NMS(Index = 59)]
        /* 0x2D4 */ public float DroneScanPlayerTime;
        [NMS(Index = 56)]
        /* 0x2D8 */ public float DroneSearchCriminalScanRadius;
        [NMS(Index = 58)]
        /* 0x2DC */ public float DroneSearchCriminalScanRadiusInShip;
        [NMS(Index = 57)]
        /* 0x2E0 */ public float DroneSearchCriminalScanRadiusWanted;
        [NMS(Index = 55)]
        /* 0x2E4 */ public float DroneSearchPauseTime;
        [NMS(Index = 54)]
        /* 0x2E8 */ public float DroneSearchRadius;
        [NMS(Index = 53)]
        /* 0x2EC */ public float DroneSearchTime;
        [NMS(Index = 71)]
        /* 0x2F0 */ public float EngineDirAngleMax;
        [NMS(Index = 70)]
        /* 0x2F4 */ public float EngineDirSpeedMin;
        [NMS(Index = 69)]
        /* 0x2F8 */ public float EyeAngleMax;
        [NMS(Index = 64)]
        /* 0x2FC */ public float EyeFocusTime;
        [NMS(Index = 66)]
        /* 0x300 */ public int EyeNumRandomsMax;
        [NMS(Index = 65)]
        /* 0x304 */ public int EyeNumRandomsMin;
        [NMS(Index = 63)]
        /* 0x308 */ public float EyeOffset;
        [NMS(Index = 68)]
        /* 0x30C */ public float EyeTimeMax;
        [NMS(Index = 67)]
        /* 0x310 */ public float EyeTimeMin;
        [NMS(Index = 41)]
        /* 0x314 */ public float HideBehindCoverHealthPercentThreshold;
        [NMS(Index = 42)]
        /* 0x318 */ public float HideBehindCoverSearchRadius;
        [NMS(Index = 60)]
        /* 0x31C */ public float LeanAmount;
        [NMS(Index = 61)]
        /* 0x320 */ public float LeanSpeedMin;
        [NMS(Index = 62)]
        /* 0x324 */ public float LeanSpeedRange;
        [NMS(Index = 43)]
        /* 0x328 */ public bool EnableCoverPlacement;
    }
}
