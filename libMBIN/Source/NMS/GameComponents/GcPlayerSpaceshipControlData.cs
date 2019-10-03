using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x154, GUID = 0x923F5436EAB7BB64, NameHash = 0x49B6F6CA72CF5A3F)]
    public class GcPlayerSpaceshipControlData : NMSTemplate
    {
        /* 0x000 */ public GcPlayerSpaceshipEngineData SpaceEngine;
        /* 0x058 */ public GcPlayerSpaceshipEngineData PlanetEngine;
        /* 0x0B0 */ public GcPlayerSpaceshipEngineData CombatEngine;

        /* 0x108 */ public float ExitHeightFactorMin;
        /* 0x10C */ public float ExitHeightFactorMax;
        /* 0x110 */ public float ExitHeightFactorPlungeMin;
        /* 0x114 */ public float ExitHeightFactorPlungeMax;
        /* 0x118 */ public float ExitAngleMin;
        /* 0x11C */ public float ExitAngleMax;
        /* 0x120 */ public float ExitLeaveAngle;
        /* 0x124 */ public TkCurveType ExitCurve;
        /* 0x128 */ public TkCurveType ExitDownCurve;
        /* 0x12C */ public float AngularFactor;
        /* 0x130 */ public float MaxTorque;
        /* 0x134 */ public float ShipPlanetBrakeMinSpeed;
        /* 0x138 */ public float ShipPlanetBrakeMaxSpeed;
        /* 0x13C */ public float ShipPlanetBrakeMinHeight;
        /* 0x140 */ public float ShipPlanetBrakeMaxHeight;
        /* 0x144 */ public float ShipPlanetBrakeForce;
        /* 0x148 */ public float ShipPlanetBrakeAlignMinTime;
        /* 0x14C */ public float ShipPlanetBrakeAlignMaxTime;
        /* 0x150 */ public float ShipMinHeightForce;
    }
}
