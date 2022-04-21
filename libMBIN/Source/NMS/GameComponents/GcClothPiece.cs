using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x380, GUID = 0xE31133DE1EFABE3F, NameHash = 0x7596FBA2C232AC37)]
    public class GcClothPiece : NMSTemplate
    {
        /* 0x000 */ public bool Enabled;
        /* 0x001 */ public NMSString0x40 DebugName;
        /* 0x041 */ public NMSString0x40 RenderMeshNodeName;
        /* 0x084 */ public int NumPointsInRenderMeshI;
        /* 0x088 */ public int NumPointsInRenderMeshJ;
        /* 0x08C */ public int VertexRemappingPermutation;
        /* 0x090 */ public int NumSimPointsI;
        /* 0x094 */ public int NumSimPointsJ;
        /* 0x098 */ public float ClothHeight;
        /* 0x09C */ public float ParticleRadius;
        /* 0x0A0 */ public float StaticFriction;
        /* 0x0A4 */ public float ParticleDamping;
        /* 0x0A8 */ public float GlobalDamping;
        /* 0x0AC */ public float StandardGravityScale;
        /* 0x0B0 */ public NMSString0x40 InitialShapeReferenceBone;
        // size: 0x3
        public enum InitialShapeSourceEnum { CapeLike, Rectangular, TakenFromSource }
        /* 0x0F0 */ public InitialShapeSourceEnum InitialShapeSource;
        /* 0x100 */ public GcCapeLikeInitialShape CapeLikeInitialShape;
        /* 0x190 */ public Vector3f TopLineStart;
        /* 0x1A0 */ public Vector3f TopLineEnd;
        /* 0x1B0 */ public Vector3f BottomLineStart;
        /* 0x1C0 */ public Vector3f BottomLineEnd;
        /* 0x1D0 */ public List<GcClothCollisionBone> CollisionBones;
        /* 0x1E0 */ public List<GcClothAttachmentCirlce> AttachmentCircles;
        /* 0x1F0 */ public List<GcClothAttachmentLine> AttachmentLines;
        /* 0x200 */ public List<GcAttachmentPointSet> AttachmentPointSets;
        /* 0x210 */ public GcConstraintsToCreateSpec ConstraintsToCreate;
        /* 0x260 */ public float AttractionStrength;
        /* 0x264 */ public bool UseInitialShapeAsAttractorShape;
        /* 0x268 */ public float AttractionRadiusAtTop;
        /* 0x26C */ public float AttractionRadiusAtBottom;
        /* 0x270 */ public GcCapeLikeInitialShape CapeLikeAttractorShape;
        /* 0x300 */ public List<NMSString0x40> NodesThatMustBePresent;
        /* 0x310 */ public List<NMSString0x40> NodesToHide;
        /* 0x320 */ public GcAdvancedTweaks Advanced;
        /* 0x348 */ public List<int> DeletedSimPoints;
        /* 0x358 */ public List<int> DeletedConstraintsI;
        /* 0x368 */ public List<int> DeletedConstraintsJ;
    }
}
