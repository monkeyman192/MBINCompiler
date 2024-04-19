using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAE05B747C16C3CA0, NameHash = 0x89A5D7902BDAFE9B, Alignment = 0x10)]
    public class GcClothComponentData : NMSTemplate
    {
        /* 0x00 */ public List<GcClothPiece> ClothPieces;
        /* 0x10 */ public float AttachmentScale;
        /* 0x14 */ public float ClothScale;
        /* 0x18 */ public float CollisionScale;
        /* 0x1C */ public int NumConstraintSolvingIterations;
        /* 0x20 */ public bool Enabled;
    }
}
