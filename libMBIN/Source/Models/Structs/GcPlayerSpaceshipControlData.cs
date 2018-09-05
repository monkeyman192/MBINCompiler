namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xFC)]
    public class GcPlayerSpaceshipControlData : NMSTemplate
    {
        /* 0x00 */ public GcPlayerSpaceshipEngineData SpaceEngine;
        /* 0x58 */ public GcPlayerSpaceshipEngineData PlanetEngine;

        /* 0xB0 */ public float ExitHeightFactorMin;
        /* 0xB4 */ public float ExitHeightFactorMax;
        /* 0xB8 */ public float ExitHeightFactorPlungeMin;
        /* 0xBC */ public float ExitHeightFactorPlungeMax;
        /* 0xC0 */ public float ExitAngleMin;
        /* 0xC4 */ public float ExitAngleMax;
        /* 0xC8 */ public float ExitLeaveAngle;

        /* 0xCC */ public TkCurveType ExitCurve;
        /* 0xD0 */ public TkCurveType ExitDownCurve;

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
