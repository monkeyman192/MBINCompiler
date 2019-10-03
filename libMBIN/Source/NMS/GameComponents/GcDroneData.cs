using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1C0, GUID = 0xD225125E5C97B384, NameHash = 0xC42B2790FC61E0A9)]
    public class GcDroneData : NMSTemplate
    {
        /* 0x000 */ public GcDroneControlData Patrol;
        /* 0x02C */ public GcDroneControlData Attack;
        /* 0x058 */ public GcDroneControlData Search;
        /* 0x084 */ public GcDroneControlData Scan;

        /* 0x0B0 */ public float CollisionAvoidOffset;
        /* 0x0B4 */ public float DronePatrolDistanceMin;
        /* 0x0B8 */ public float DronePatrolDistanceMax;
        /* 0x0BC */ public float DronePatrolTargetDistance;
        /* 0x0C0 */ public float DronePatrolInspectDistanceMin;
        /* 0x0C4 */ public float DronePatrolInspectDistanceMax;
        /* 0x0C8 */ public float DronePatrolInspectTargetTime;
        /* 0x0CC */ public float DronePatrolInspectSwitchTime;
        /* 0x0D0 */ public float DronePatrolInspectRadius;
        /* 0x0D4 */ public float DronePatrolRepelDistance;
        /* 0x0D8 */ public float DronePatrolRepelStrength;
        /* 0x0DC */ public float DronePatrolHonkRadius;
        /* 0x0E0 */ public float DronePatrolHonkTime;
        /* 0x0E4 */ public int DronePatrolHonkProbability;
        /* 0x0E8 */ public float DroneAlertTime;
        /* 0x0EC */ public float AttackFireRate;
        /* 0x0F0 */ public float AttackTimeout;
        /* 0x0F4 */ public int AttackNumShotsMin;
        /* 0x0F8 */ public int AttackNumShotsMax;
        /* 0x0FC */ public float AttackFireTimeMin;
        /* 0x100 */ public float AttackFireTimeMax;
        /* 0x104 */ public float AttackMoveLookDistanceRange;
        /* 0x108 */ public float AttackMoveLookDistanceMin;
        /* 0x10C */ public float AttackAngle;
        /* 0x110 */ public float AttackRange;
        /* 0x114 */ public float AttackMinSpeed;
        /* 0x118 */ public float AttackActivateTime;
        /* 0x11C */ public float AttackBobAmount;
        /* 0x120 */ public float AttackBobRotation;
        /* 0x124 */ public float AttackMoveDistanceMin;
        /* 0x128 */ public float AttackMoveDistanceMax;
        /* 0x12C */ public float AttackMoveMinChoiceTime;
        /* 0x130 */ public float AttackMoveAngle;
        /* 0x134 */ public float AttackMaxDistanceFromAlert;
        /* 0x138 */ public float AttackAlertFailTime;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding13C;

        /* 0x140 */ public Colour EyeColourAlert;
        /* 0x150 */ public Colour EyeColourSearch;
        /* 0x160 */ public Colour EyeColourPatrol;

        /* 0x170 */ public float DroneSearchTime;
        /* 0x174 */ public float DroneSearchRadius;
        /* 0x178 */ public float DroneSearchPauseTime;
        /* 0x17C */ public float DroneSearchCriminalScanRadius;
        /* 0x180 */ public float DroneSearchCriminalScanRadiusInShip;
        /* 0x184 */ public float DroneScanPlayerTime;
        /* 0x188 */ public float LeanAmount;
        /* 0x18C */ public float LeanSpeedMin;
        /* 0x190 */ public float LeanSpeedRange;
        /* 0x194 */ public float EyeOffset;
        /* 0x198 */ public float EyeFocusTime;
        /* 0x19C */ public int EyeNumRandomsMin;
        /* 0x1A0 */ public int EyeNumRandomsMax;
        /* 0x1A4 */ public float EyeTimeMin;
        /* 0x1A8 */ public float EyeTimeMax;
        /* 0x1AC */ public float EyeAngleMax;
        /* 0x1B0 */ public float EngineDirSpeedMin;
        /* 0x1B4 */ public float EngineDirAngleMax;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x1B8 */ public byte[] EndPadding;
    }
}
