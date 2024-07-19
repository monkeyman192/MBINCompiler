using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE6E2628E53434D01, NameHash = 0x161DC486, Alignment = 0x10)]
    public class GcClothComponentData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public List<GcClothPiece> ClothPieces;
        [NMS(Index = 6)]
        /* 0x10 */ public float AttachmentScale;
        [NMS(Index = 4)]
        /* 0x14 */ public float ClothScale;
        [NMS(Index = 5)]
        /* 0x18 */ public float CollisionScale;
        [NMS(Index = 1)]
        /* 0x1C */ public float InitialOverSolveForConstraints;
        [NMS(Index = 2)]
        /* 0x20 */ public float InitialOverSolveForContacts;
        [NMS(Index = 8)]
        /* 0x24 */ public float MaxAngularSpeedFeltByDynamics;
        [NMS(Index = 7)]
        /* 0x28 */ public float MaxLinearSpeedFeltByDynamics;
        [NMS(Index = 0)]
        /* 0x2C */ public bool Enabled;
    }
}
