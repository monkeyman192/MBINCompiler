using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB6C2A059DCAAB297, NameHash = 0x7596FBA2C232AC37)]
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
        /* 0x0A4 */ public float DampingWrtFixed;
        /* 0x0A8 */ public float AbsoluteDamping;
        /* 0x0AC */ public float StandardGravityScale;
        /* 0x0B0 */ public NMSString0x40 InitialShapeReferenceBone;
        // size: 0x3
        public enum ScaleInTransformApplicationOnClothEnum { Multiply, Divide, Ignore }
        /* 0x0F0 */ public ScaleInTransformApplicationOnClothEnum ScaleInTransformApplicationOnCloth;
        // size: 0x3
        public enum ScaleInTransformApplicationOnCollisionEnum { Multiply, Divide, Ignore }
        /* 0x0F4 */ public ScaleInTransformApplicationOnCollisionEnum ScaleInTransformApplicationOnCollision;
        // size: 0x3
        public enum ScaleInTransformApplicationOnAttachmentEnum { Multiply, Divide, Ignore }
        /* 0x0F8 */ public ScaleInTransformApplicationOnAttachmentEnum ScaleInTransformApplicationOnAttachment;
        // size: 0x3
        public enum InitialShapeSourceEnum { CapeLike, Rectangular, TakenFromSource }
        /* 0x0FC */ public InitialShapeSourceEnum InitialShapeSource;
        /* 0x100 */ public GcCapeLikeInitialShape CapeLikeInitialShape;
        /* 0x190 */ public GcRectangularInitialShape RectangularInitialShape;
        /* 0x1D0 */ public List<GcClothCollisionBone> CollisionBones;
        /* 0x1E0 */ public List<GcClothAttachmentCirlce> AttachmentCircles;
        /* 0x1F0 */ public List<GcClothAttachmentLine> AttachmentLines;
        /* 0x200 */ public List<GcAttachmentPointSet> AttachmentPointSets;
        /* 0x210 */ public GcConstraintsToCreateSpec ConstraintsToCreate;
        /* 0x260 */ public GcClothAttractor Attractor;
        /* 0x300 */ public List<NMSString0x40> NodesThatMustBePresent;
        /* 0x310 */ public List<NMSString0x40> NodesToHide;
        /* 0x320 */ public GcAdvancedTweaks Advanced;
        /* 0x348 */ public List<int> DeletedSimPoints;
        /* 0x358 */ public List<int> DeletedConstraintsI;
        /* 0x368 */ public List<int> DeletedConstraintsJ;
    }
}
