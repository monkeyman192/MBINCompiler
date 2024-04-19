using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x13D85FADF967EDC, NameHash = 0x1F15CCCBBBCEC86A)]
    public class GcCreatureMovementData : NMSTemplate
    {
        /* 0x00 */ public List<GcCreatureMoveAnimData> Anims;
        /* 0x10 */ public float HeightMax;
        /* 0x14 */ public float HeightMin;
        /* 0x18 */ public float HeightTime;
        /* 0x1C */ public float MoveRange;
        /* 0x20 */ public float MoveSpeedScale;
        /* 0x24 */ public float TurnRadiusScale;
        /* 0x28 */ public bool Herd;
    }
}
