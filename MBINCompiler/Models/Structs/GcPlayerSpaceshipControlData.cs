namespace MBINCompiler.Models.Structs
{
    public class GcPlayerSpaceshipControlData : NMSTemplate     // size = 0xF4
    {
        public GcPlayerSpaceshipEngineData SpaceEngine;
        public GcPlayerSpaceshipEngineData PlanetEngine;

        public float ExitHeightFactorMin;
        public float ExitHeightFactorMax;
        public float ExitHeightFactorPlungeMin;
        public float ExitHeightFactorPlungeMax;
        public float ExitAngleMin;
        public float ExitAngleMax;
        public float ExitLeaveAngle;

        public TkCurveType ExitCurve;
        public TkCurveType ExitDownCurve;

        public float AngularFactor;
        public float MaxTorque;
        public float ShipPlanetBrakeMinSpeed;
        public float ShipPlanetBrakeMaxSpeed;
        public float ShipPlanetBrakeMinHeight;
        public float ShipPlanetBrakeMaxHeight;
        public float ShipPlanetBrakeForce;
        public float ShipPlanetBrakeAlignMinTime;
        public float ShipPlanetBrakeAlignMaxTime;

        public float ShipMinHeightForce;
    }
}
