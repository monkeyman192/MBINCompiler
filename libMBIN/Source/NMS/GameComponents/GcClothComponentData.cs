using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF470C35C199DB332, NameHash = 0x89A5D7902BDAFE9B, Alignment = 0x10)]
    public class GcClothComponentData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<GcClothPiece> ClothPieces;
        [NMS(Index = 5)]
        /* 0x10 */ public float AttachmentScale;
        [NMS(Index = 3)]
        /* 0x14 */ public float ClothScale;
        [NMS(Index = 4)]
        /* 0x18 */ public float CollisionScale;
        [NMS(Index = 1)]
        /* 0x1C */ public int NumConstraintSolvingIterations;
        [NMS(Index = 0)]
        /* 0x20 */ public bool Enabled;
    }
}
