using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x89E1E1205BB6EA1A, NameHash = 0xC42B2790FC61E0A9)]
    public class GcDroneData : NMSTemplate
    {
        /* 0x000 */ public Colour EyeColourAlert;
        /* 0x010 */ public Colour EyeColourPatrol;
        /* 0x020 */ public Colour EyeColourSearch;
        /* 0x030 */ public NMSString0x10 DamageEffect;
        /* 0x040 */ public GcSentinelResource CoverResource;
        /* 0x0D4 */ public GcDroneControlData Attack;
        /* 0x104 */ public GcDroneControlData Friendly;
        /* 0x134 */ public GcDroneControlData FriendlyFast;
        /* 0x164 */ public GcDroneControlData Patrol;
        /* 0x194 */ public GcDroneControlData Repair;
        /* 0x1C4 */ public GcDroneControlData Scan;
        /* 0x1F4 */ public GcDroneControlData Search;
        /* 0x224 */ public GcDroneControlData Stun;
        /* 0x254 */ public GcDroneControlData Summon;
        /* 0x284 */ public GcDroneControlData ToCover;
        /* 0x2B4 */ public float AttackActivateTime;
        /* 0x2B8 */ public float AttackAlertFailTime;
        /* 0x2BC */ public float AttackAngle;
        /* 0x2C0 */ public float AttackBobAmount;
        /* 0x2C4 */ public float AttackBobRotation;
        /* 0x2C8 */ public float AttackMaxDistanceFromAlert;
        /* 0x2CC */ public float AttackMinSpeed;
        /* 0x2D0 */ public float AttackMoveAngle;
        /* 0x2D4 */ public float AttackMoveLookDistanceMin;
        /* 0x2D8 */ public float AttackMoveLookDistanceRange;
        /* 0x2DC */ public float AttackMoveMinChoiceTime;
        /* 0x2E0 */ public float CollisionAvoidOffset;
        /* 0x2E4 */ public float CoverPlacementActivateTime;
        /* 0x2E8 */ public float CoverPlacementActivateTimeMaxRandomExtra;
        /* 0x2EC */ public float CoverPlacementCooldownTime;
        /* 0x2F0 */ public int CoverPlacementMaxActiveCover;
        /* 0x2F4 */ public float CoverPlacementMaxDistanceFromSelf;
        /* 0x2F8 */ public float CoverPlacementMinDistanceFromSelf;
        /* 0x2FC */ public float CoverPlacementMinDistanceFromTarget;
        /* 0x300 */ public float CoverPlacementUpOffset;
        /* 0x304 */ public float DamageEffectHealthPercentThreshold;
        /* 0x308 */ public float DroneAlertTime;
        /* 0x30C */ public float DronePatrolDistanceMax;
        /* 0x310 */ public float DronePatrolDistanceMin;
        /* 0x314 */ public int DronePatrolHonkProbability;
        /* 0x318 */ public float DronePatrolHonkRadius;
        /* 0x31C */ public float DronePatrolHonkTime;
        /* 0x320 */ public float DronePatrolInspectDistanceMax;
        /* 0x324 */ public float DronePatrolInspectDistanceMin;
        /* 0x328 */ public float DronePatrolInspectRadius;
        /* 0x32C */ public float DronePatrolInspectSwitchTime;
        /* 0x330 */ public float DronePatrolInspectTargetTime;
        /* 0x334 */ public float DronePatrolRepelDistance;
        /* 0x338 */ public float DronePatrolRepelStrength;
        /* 0x33C */ public float DronePatrolTargetDistance;
        /* 0x340 */ public float DroneScanPlayerTime;
        /* 0x344 */ public float DroneSearchCriminalScanRadius;
        /* 0x348 */ public float DroneSearchCriminalScanRadiusInShip;
        /* 0x34C */ public float DroneSearchCriminalScanRadiusWanted;
        /* 0x350 */ public float DroneSearchPauseTime;
        /* 0x354 */ public float DroneSearchRadius;
        /* 0x358 */ public float DroneSearchTime;
        /* 0x35C */ public float EngineDirAngleMax;
        /* 0x360 */ public float EngineDirSpeedMin;
        /* 0x364 */ public float EyeAngleMax;
        /* 0x368 */ public float EyeFocusTime;
        /* 0x36C */ public int EyeNumRandomsMax;
        /* 0x370 */ public int EyeNumRandomsMin;
        /* 0x374 */ public float EyeOffset;
        /* 0x378 */ public float EyeTimeMax;
        /* 0x37C */ public float EyeTimeMin;
        /* 0x380 */ public float HideBehindCoverHealthPercentThreshold;
        /* 0x384 */ public float HideBehindCoverSearchRadius;
        /* 0x388 */ public float LeanAmount;
        /* 0x38C */ public float LeanSpeedMin;
        /* 0x390 */ public float LeanSpeedRange;
        /* 0x394 */ public bool EnableCoverPlacement;
    }
}
