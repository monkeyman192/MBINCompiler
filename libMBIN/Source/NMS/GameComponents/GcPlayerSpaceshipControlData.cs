using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x49C1C3C1669B8E88, NameHash = 0x7B3F6835)]
    public class GcPlayerSpaceshipControlData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public GcPlayerSpaceshipEngineData AtmosCombatEngine;
        [NMS(Index = 2)]
        /* 0x074 */ public GcPlayerSpaceshipEngineData CombatEngine;
        [NMS(Index = 1)]
        /* 0x0E8 */ public GcPlayerSpaceshipEngineData PlanetEngine;
        [NMS(Index = 0)]
        /* 0x15C */ public GcPlayerSpaceshipEngineData SpaceEngine;
        [NMS(Index = 13)]
        /* 0x1D0 */ public float AngularFactor;
        [NMS(Index = 9)]
        /* 0x1D4 */ public float ExitAngleMax;
        [NMS(Index = 8)]
        /* 0x1D8 */ public float ExitAngleMin;
        [NMS(Index = 5)]
        /* 0x1DC */ public float ExitHeightFactorMax;
        [NMS(Index = 4)]
        /* 0x1E0 */ public float ExitHeightFactorMin;
        [NMS(Index = 7)]
        /* 0x1E4 */ public float ExitHeightFactorPlungeMax;
        [NMS(Index = 6)]
        /* 0x1E8 */ public float ExitHeightFactorPlungeMin;
        [NMS(Index = 10)]
        /* 0x1EC */ public float ExitLeaveAngle;
        [NMS(Index = 14)]
        /* 0x1F0 */ public float MaxTorque;
        [NMS(Index = 22)]
        /* 0x1F4 */ public float ShipMinHeightForce;
        [NMS(Index = 21)]
        /* 0x1F8 */ public float ShipPlanetBrakeAlignMaxTime;
        [NMS(Index = 20)]
        /* 0x1FC */ public float ShipPlanetBrakeAlignMinTime;
        [NMS(Index = 19)]
        /* 0x200 */ public float ShipPlanetBrakeForce;
        [NMS(Index = 18)]
        /* 0x204 */ public float ShipPlanetBrakeMaxHeight;
        [NMS(Index = 16)]
        /* 0x208 */ public float ShipPlanetBrakeMaxSpeed;
        [NMS(Index = 17)]
        /* 0x20C */ public float ShipPlanetBrakeMinHeight;
        [NMS(Index = 15)]
        /* 0x210 */ public float ShipPlanetBrakeMinSpeed;
        [NMS(Index = 11)]
        /* 0x214 */ public TkCurveType ExitCurve;
        [NMS(Index = 12)]
        /* 0x215 */ public TkCurveType ExitDownCurve;
    }
}
