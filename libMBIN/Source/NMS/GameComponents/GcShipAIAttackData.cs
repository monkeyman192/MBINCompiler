using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcShipAIAttackData : NMSTemplate
    {
        public float AttackWeaponRange;
        public float AttackAngle;
        public float AttackShootWaitTime;
        public float AttackShootTimeMin;
        public float AttackShootTimeMax;
        public float AttackReadyTime;
        public float AttackMaxTime;
        public float AttackApproachOffset;
        public float AttackApproachMinRange;
        public float AttackApproachMaxRange;
        public float AttackTooCloseRange;
        public float AttackFlybyOffset;
        public float AttackBoostTimeToRange;
        public float AttackBoostRange;
        public float AttackBoostAngle;
        public float AttackTurnMultiplier;
        public float AttackFacingAimReducer;
        public float AttackMaxPlanetHeight;
        public int NumHitsBeforeBail;
        public int NumHitsBeforeReposition;
        public float FleeBrake;
        public float FleeBoost;
        public float FleeBrakeTime;
        public float FleeRepositionTime;
        public float FleeRepositionAngleMin;
        public float FleeRepositionAngleMax;
        public float FleeRepositionBoostTime;
        public float FleeRange;
        public float FleeMinTime;
        public float FleeMaxTime;
        public float AttackTargetMinRange;
        public float AttackTargetMaxRange;
        public float AttackTargetOffsetMin;
        public float AttackTargetOffsetMax;
        public float AttackTargetSwitchTargetTime;
    }
}
