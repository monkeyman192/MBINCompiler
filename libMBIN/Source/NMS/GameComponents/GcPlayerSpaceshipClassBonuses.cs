namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x750D69F09ECA8D35, NameHash = 0x98CA1B16)]
    public class GcPlayerSpaceshipClassBonuses : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public float BoostingTurnDampMax;
        [NMS(Index = 7)]
        /* 0x04 */ public float BoostingTurnDampMin;
        [NMS(Index = 4)]
        /* 0x08 */ public float BoostMaxSpeedMax;
        [NMS(Index = 5)]
        /* 0x0C */ public float BoostMaxSpeedMin;
        [NMS(Index = 9)]
        /* 0x10 */ public float DirectionBrakeMax;
        [NMS(Index = 8)]
        /* 0x14 */ public float DirectionBrakeMin;
        [NMS(Index = 2)]
        /* 0x18 */ public float MaxSpeedMax;
        [NMS(Index = 3)]
        /* 0x1C */ public float MaxSpeedMin;
        [NMS(Index = 0)]
        /* 0x20 */ public float ThrustForceMax;
        [NMS(Index = 1)]
        /* 0x24 */ public float ThrustForceMin;
        [NMS(Index = 10)]
        /* 0x28 */ public float TurnStrengthMax;
        [NMS(Index = 11)]
        /* 0x2C */ public float TurnStrengthMin;
    }
}
