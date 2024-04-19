namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA55A702EC8C6D49F, NameHash = 0xED083CF705C39B97)]
    public class GcCreatureFlockMovementData : NMSTemplate
    {
        /* 0x00 */ public float BankTime;
        /* 0x04 */ public float FlockAlign;
        /* 0x08 */ public float FlockAvoidPredators;
        /* 0x0C */ public float FlockAvoidPredatorsMaxDist;
        /* 0x10 */ public float FlockAvoidPredatorsMinDist;
        /* 0x14 */ public float FlockAvoidPredatorsSpeedBoost;
        /* 0x18 */ public float FlockAvoidTerrain;
        /* 0x1C */ public float FlockAvoidTerrainMaxDist;
        /* 0x20 */ public float FlockAvoidTerrainMinDist;
        /* 0x24 */ public float FlockCohere;
        /* 0x28 */ public float FlockFollow;
        /* 0x2C */ public float FlockHysteresis;
        /* 0x30 */ public float FlockMoveDirectionTime;
        /* 0x34 */ public float FlockMoveSpeed;
        /* 0x38 */ public float FlockSeperate;
        /* 0x3C */ public float FlockSeperateMaxDist;
        /* 0x40 */ public float FlockSeperateMinDist;
        /* 0x44 */ public float FlockTurnAngle;
        /* 0x48 */ public float MaxBank;
        /* 0x4C */ public float MaxFlapSpeed;
        /* 0x50 */ public int MaxFlockMembers;
        /* 0x54 */ public float MinFlapSpeed;
        /* 0x58 */ public int MinFlockMembers;
        /* 0x5C */ public float MoveInFacingStrength;
    }
}
