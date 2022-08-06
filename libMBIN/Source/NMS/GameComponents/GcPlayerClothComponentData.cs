using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    // Inexplicably this class has an alignment of 0x10. I can't see a reason for this,]
    // unless the first class of a generic list always has an alignment of 0x10???
    // Will need more investigation...
    [NMS(GUID = 0xCFCC496EAF24EC6F, NameHash = 0x7095201046A71EFE, Alignment = 0x10)]
    public class GcPlayerClothComponentData : NMSTemplate
    {
        /* 0x00 */ public bool Enabled;
        /* 0x04 */ public int NumConstraintSolvingIterations;
        /* 0x08 */ public List<GcClothPiece> ClothPieces;
        /* 0x18 */ public float ClothScale;
        /* 0x1C */ public float CollisionScale;
        /* 0x20 */ public float AttachmentScale;
    }
}
