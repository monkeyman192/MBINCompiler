using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFDEE1400FF8775A9, NameHash = 0xED083CF705C39B97)]
    public class GcCreatureFlockMovementData : NMSTemplate
    {
        /* 0x00 */ public int MinFlockMembers;
        /* 0x04 */ public int MaxFlockMembers;
        /* 0x08 */ public float FlockFollow;
        /* 0x0C */ public float FlockHysteresis;
        /* 0x10 */ public float FlockCohere;
        /* 0x14 */ public float FlockSeperate;
        /* 0x18 */ public float FlockSeperateMinDist;
        /* 0x1C */ public float FlockSeperateMaxDist;
        /* 0x20 */ public float FlockAlign;
        /* 0x24 */ public float FlockAvoidTerrain;
        /* 0x28 */ public float FlockAvoidTerrainMinDist;
        /* 0x2C */ public float FlockAvoidTerrainMaxDist;
        /* 0x30 */ public float FlockAvoidPredators;
        /* 0x34 */ public float FlockAvoidPredatorsMinDist;
        /* 0x38 */ public float FlockAvoidPredatorsMaxDist;
        /* 0x3C */ public float FlockAvoidPredatorsSpeedBoost;
        /* 0x40 */ public float MoveInFacingStrength;
        /* 0x44 */ public float FlockMoveSpeed;
        /* 0x48 */ public float FlockMoveDirectionTime;
        /* 0x4C */ public float FlockTurnAngle;
        /* 0x50 */ public float MaxBank;
        /* 0x54 */ public float BankTime;
        /* 0x58 */ public float MinFlapSpeed;
        /* 0x5C */ public float MaxFlapSpeed;
    }
}
