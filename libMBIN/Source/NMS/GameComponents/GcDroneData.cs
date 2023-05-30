using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcDroneData : NMSTemplate
    {
        public GcDroneControlData Patrol;
        public GcDroneControlData Attack;
        public GcDroneControlData Search;
        public GcDroneControlData Scan;

        public float CollisionAvoidOffset;

        public float DronePatrolDistanceMin;
        public float DronePatrolDistanceMax;
        public float DronePatrolTargetDistance;
        public float DronePatrolInspectDistanceMin;
        public float DronePatrolInspectDistanceMax;
        public float DronePatrolInspectTargetTime;
        public float DronePatrolInspectSwitchTime;
        public float DronePatrolInspectRadius;
        public float DronePatrolRepelDistance;
        public float DronePatrolRepelStrength;
        public float DronePatrolHonkRadius;
        public float DronePatrolHonkTime;
        public int DronePatrolHonkProbability;

        public float DroneAlertTime;

        public float AttackFireRate;
        public int AttackNumShotsMin;
        public int AttackNumShotsMax;
        public float AttackFireTimeMin;
        public float AttackFireTimeMax;
        public float AttackMoveLookDistanceRange;
        public float AttackMoveLookDistanceMin;
        public float AttackAngle;
        public float AttackRange;
        public float AttackMinSpeed;
        public float AttackActivateTime;
        public float AttackBobAmount;
        public float AttackBobRotation;
        public float AttackMoveDistanceMin;
        public float AttackMoveDistanceMax;
        public float AttackMoveMinChoiceTime;
        public float AttackTargetDistanceMin;
        public float AttackTargetDistanceMax;
        public float AttackMaxDistanceFromAlert;
        public float AttackAlertFailTime;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding13C;

        public Colour EyeColourAlert;
        public Colour EyeColourSearch;
        public Colour EyeColourPatrol;

        public float DroneSearchTime;
        public float DroneSearchRadius;
        public float DroneSearchPauseTime;
        public float DroneSearchCriminalScanRadius;

        public float DroneScanPlayerTime;

        public float LeanAmount;
        public float LeanSpeedMin;
        public float LeanSpeedRange;

        public float EyeOffset;
        public float EyeFocusTime;
        public int EyeNumRandomsMin;
        public int EyeNumRandomsMax;
        public float EyeTimeMin;
        public float EyeTimeMax;
        public float EyeAngleMax;

        public float EngineDirSpeedMin;
        public float EngineDirAngleMax;

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding1B4;
    }
}
