using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4AA758926A0C77DE, NameHash = 0xC42B2790FC61E0A9)]
    public class GcDroneData : NMSTemplate
    {
        /* 0x000 */ public GcDroneControlData Patrol;
        /* 0x030 */ public GcDroneControlData Attack;
        /* 0x060 */ public GcDroneControlData Search;
        /* 0x090 */ public GcDroneControlData Scan;
        /* 0x0C0 */ public GcDroneControlData Repair;
        /* 0x0F0 */ public GcDroneControlData Summon;
        /* 0x120 */ public GcDroneControlData ToCover;
        /* 0x150 */ public GcDroneControlData Stun;
        /* 0x180 */ public GcDroneControlData Friendly;
        /* 0x1B0 */ public GcDroneControlData FriendlyFast;
        /* 0x1E0 */ public float CollisionAvoidOffset;
        /* 0x1E4 */ public float DronePatrolDistanceMin;
        /* 0x1E8 */ public float DronePatrolDistanceMax;
        /* 0x1EC */ public float DronePatrolTargetDistance;
        /* 0x1F0 */ public float DronePatrolInspectDistanceMin;
        /* 0x1F4 */ public float DronePatrolInspectDistanceMax;
        /* 0x1F8 */ public float DronePatrolInspectTargetTime;
        /* 0x1FC */ public float DronePatrolInspectSwitchTime;
        /* 0x200 */ public float DronePatrolInspectRadius;
        /* 0x204 */ public float DronePatrolRepelDistance;
        /* 0x208 */ public float DronePatrolRepelStrength;
        /* 0x20C */ public float DronePatrolHonkRadius;
        /* 0x210 */ public float DronePatrolHonkTime;
        /* 0x214 */ public int DronePatrolHonkProbability;
        /* 0x218 */ public float DroneAlertTime;
        /* 0x21C */ public float AttackMoveLookDistanceRange;
        /* 0x220 */ public float AttackMoveLookDistanceMin;
        /* 0x224 */ public float AttackAngle;
        /* 0x228 */ public float AttackMinSpeed;
        /* 0x22C */ public float AttackActivateTime;
        /* 0x230 */ public float AttackBobAmount;
        /* 0x234 */ public float AttackBobRotation;
        /* 0x238 */ public float AttackMoveMinChoiceTime;
        /* 0x23C */ public float AttackMoveAngle;
        /* 0x240 */ public float AttackMaxDistanceFromAlert;
        /* 0x244 */ public float AttackAlertFailTime;
        /* 0x250 */ public Colour EyeColourAlert;
        /* 0x260 */ public Colour EyeColourSearch;
        /* 0x270 */ public Colour EyeColourPatrol;
        /* 0x280 */ public NMSString0x10 DamageEffect;
        /* 0x290 */ public float DamageEffectHealthPercentThreshold;
        /* 0x294 */ public float HideBehindCoverHealthPercentThreshold;
        /* 0x298 */ public float HideBehindCoverSearchRadius;
        /* 0x29C */ public bool EnableCoverPlacement;
        /* 0x2A0 */ public float CoverPlacementActivateTime;
        /* 0x2A4 */ public float CoverPlacementActivateTimeMaxRandomExtra;
        /* 0x2A8 */ public float CoverPlacementCooldownTime;
        /* 0x2AC */ public float CoverPlacementMinDistanceFromTarget;
        /* 0x2B0 */ public float CoverPlacementMinDistanceFromSelf;
        /* 0x2B4 */ public float CoverPlacementMaxDistanceFromSelf;
        /* 0x2B8 */ public float CoverPlacementUpOffset;
        /* 0x2BC */ public int CoverPlacementMaxActiveCover;
        /* 0x2C0 */ public GcSentinelResource CoverResource;
        /* 0x340 */ public int BaseHealth;
        /* 0x344 */ public int HealthIncreasePerLevel;
        /* 0x348 */ public float RepairTime;
        /* 0x34C */ public float RepairThreshold;
        /* 0x350 */ public float DroneSearchTime;
        /* 0x354 */ public float DroneSearchRadius;
        /* 0x358 */ public float DroneSearchPauseTime;
        /* 0x35C */ public float DroneSearchCriminalScanRadius;
        /* 0x360 */ public float DroneSearchCriminalScanRadiusWanted;
        /* 0x364 */ public float DroneSearchCriminalScanRadiusInShip;
        /* 0x368 */ public float DroneScanPlayerTime;
        /* 0x36C */ public float LeanAmount;
        /* 0x370 */ public float LeanSpeedMin;
        /* 0x374 */ public float LeanSpeedRange;
        /* 0x378 */ public float EyeOffset;
        /* 0x37C */ public float EyeFocusTime;
        /* 0x380 */ public int EyeNumRandomsMin;
        /* 0x384 */ public int EyeNumRandomsMax;
        /* 0x388 */ public float EyeTimeMin;
        /* 0x38C */ public float EyeTimeMax;
        /* 0x390 */ public float EyeAngleMax;
        /* 0x394 */ public float EngineDirSpeedMin;
        /* 0x398 */ public float EngineDirAngleMax;
    }
}
