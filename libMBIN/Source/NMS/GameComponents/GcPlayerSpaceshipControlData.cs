using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAB72AFECF5631053, NameHash = 0x49B6F6CA72CF5A3F)]
    public class GcPlayerSpaceshipControlData : NMSTemplate
    {
        /* 0x000 */ public GcPlayerSpaceshipEngineData SpaceEngine;
        /* 0x074 */ public GcPlayerSpaceshipEngineData PlanetEngine;
        /* 0x0E8 */ public GcPlayerSpaceshipEngineData CombatEngine;
        /* 0x15C */ public GcPlayerSpaceshipEngineData AtmosCombatEngine;
        /* 0x1D0 */ public float ExitHeightFactorMin;
        /* 0x1D4 */ public float ExitHeightFactorMax;
        /* 0x1D8 */ public float ExitHeightFactorPlungeMin;
        /* 0x1DC */ public float ExitHeightFactorPlungeMax;
        /* 0x1E0 */ public float ExitAngleMin;
        /* 0x1E4 */ public float ExitAngleMax;
        /* 0x1E8 */ public float ExitLeaveAngle;
        /* 0x1EC */ public TkCurveType ExitCurve;
        /* 0x1F0 */ public TkCurveType ExitDownCurve;
        /* 0x1F4 */ public float AngularFactor;
        /* 0x1F8 */ public float MaxTorque;
        /* 0x1FC */ public float ShipPlanetBrakeMinSpeed;
        /* 0x200 */ public float ShipPlanetBrakeMaxSpeed;
        /* 0x204 */ public float ShipPlanetBrakeMinHeight;
        /* 0x208 */ public float ShipPlanetBrakeMaxHeight;
        /* 0x20C */ public float ShipPlanetBrakeForce;
        /* 0x210 */ public float ShipPlanetBrakeAlignMinTime;
        /* 0x214 */ public float ShipPlanetBrakeAlignMaxTime;
        /* 0x218 */ public float ShipMinHeightForce;
    }
}
