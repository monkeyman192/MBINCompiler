using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDF7115C82E98A332, NameHash = 0x44F790BC)]
    public class GcCreatureMovementData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcCreatureMoveAnimData> Anims;
        [NMS(Index = 5)]
        /* 0x10 */ public float HeightMax;
        [NMS(Index = 4)]
        /* 0x14 */ public float HeightMin;
        [NMS(Index = 6)]
        /* 0x18 */ public float HeightTime;
        [NMS(Index = 1)]
        /* 0x1C */ public float MoveRange;
        [NMS(Index = 2)]
        /* 0x20 */ public float MoveSpeedScale;
        [NMS(Index = 3)]
        /* 0x24 */ public float TurnRadiusScale;
        [NMS(Index = 7)]
        /* 0x28 */ public bool Herd;
        [NMS(Index = 8)]
        /* 0x29 */ public bool IgnoreRotationInPounce;
    }
}
