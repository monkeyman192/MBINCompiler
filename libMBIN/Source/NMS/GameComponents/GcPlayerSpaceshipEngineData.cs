using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x58, GUID = 0x5526B7917EA8D181, NameHash = 0x1C062102935FA221)]
    public class GcPlayerSpaceshipEngineData : NMSTemplate
    {
        public float ThrustForce;
        public float MaxSpeed;
        public float MinSpeed;
        public float Falloff;
        public float MinSpeedForce;
        public float BoostThrustForce;
        public float BoostMaxSpeed;
        public float BoostFalloff;
        public float BoostingTurnDamp;
        public float DirectionBrakeMin;
        public float DirectionBrake;
        public float ReverseBrake;
        public float OverspeedBrake;
        public float LowSpeedTurnDamper;
        public float TurnBrakeMin;
        public float TurnBrakeMax;
        public float TurnStrength;
        public float RollAmount;
        public float RollForce;
        public float RollAutoTime;
        public float BalanceTimeMin;
        public float BalanceTimeMax;
    }
}
