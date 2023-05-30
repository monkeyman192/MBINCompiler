using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcPlayerSpaceshipControlData : NMSTemplate
    {
        public GcPlayerSpaceshipEngineData SpaceEngine;
        public GcPlayerSpaceshipEngineData PlanetEngine;

        public float ExitHeightFactorMin;
        public float ExitHeightFactorMax;
        public float ExitHeightFactorPlungeMin;
        public float ExitHeightFactorPlungeMax;
        public float ExitAngleMin;
        public float ExitAngleMax;

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
