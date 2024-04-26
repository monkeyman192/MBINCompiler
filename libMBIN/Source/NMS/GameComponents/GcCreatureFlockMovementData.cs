namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA55A702EC8C6D49F, NameHash = 0xED083CF705C39B97)]
    public class GcCreatureFlockMovementData : NMSTemplate
    {
        [NMS(Index = 21)]
        /* 0x00 */ public float BankTime;
        [NMS(Index = 8)]
        /* 0x04 */ public float FlockAlign;
        [NMS(Index = 12)]
        /* 0x08 */ public float FlockAvoidPredators;
        [NMS(Index = 14)]
        /* 0x0C */ public float FlockAvoidPredatorsMaxDist;
        [NMS(Index = 13)]
        /* 0x10 */ public float FlockAvoidPredatorsMinDist;
        [NMS(Index = 15)]
        /* 0x14 */ public float FlockAvoidPredatorsSpeedBoost;
        [NMS(Index = 9)]
        /* 0x18 */ public float FlockAvoidTerrain;
        [NMS(Index = 11)]
        /* 0x1C */ public float FlockAvoidTerrainMaxDist;
        [NMS(Index = 10)]
        /* 0x20 */ public float FlockAvoidTerrainMinDist;
        [NMS(Index = 4)]
        /* 0x24 */ public float FlockCohere;
        [NMS(Index = 2)]
        /* 0x28 */ public float FlockFollow;
        [NMS(Index = 3)]
        /* 0x2C */ public float FlockHysteresis;
        [NMS(Index = 18)]
        /* 0x30 */ public float FlockMoveDirectionTime;
        [NMS(Index = 17)]
        /* 0x34 */ public float FlockMoveSpeed;
        [NMS(Index = 5)]
        /* 0x38 */ public float FlockSeperate;
        [NMS(Index = 7)]
        /* 0x3C */ public float FlockSeperateMaxDist;
        [NMS(Index = 6)]
        /* 0x40 */ public float FlockSeperateMinDist;
        [NMS(Index = 19)]
        /* 0x44 */ public float FlockTurnAngle;
        [NMS(Index = 20)]
        /* 0x48 */ public float MaxBank;
        [NMS(Index = 23)]
        /* 0x4C */ public float MaxFlapSpeed;
        [NMS(Index = 1)]
        /* 0x50 */ public int MaxFlockMembers;
        [NMS(Index = 22)]
        /* 0x54 */ public float MinFlapSpeed;
        [NMS(Index = 0)]
        /* 0x58 */ public int MinFlockMembers;
        [NMS(Index = 16)]
        /* 0x5C */ public float MoveInFacingStrength;
    }
}
