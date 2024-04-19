using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x615EA6466922EFC5, NameHash = 0x7596FBA2C232AC37)]
    public class GcClothPiece : NMSTemplate
    {
        /* 0x000 */ public GcRectangularInitialShape RectangularInitialShape;
        /* 0x040 */ public GcAdvancedTweaks Advanced;
        /* 0x080 */ public List<GcAttachedNode> AttachedNodes;
        /* 0x090 */ public List<GcClothAttachmentCirlce> AttachmentCircles;
        /* 0x0A0 */ public List<GcClothAttachmentLine> AttachmentLines;
        /* 0x0B0 */ public List<GcAttachmentPointSet> AttachmentPointSets;
        /* 0x0C0 */ public List<GcCollisionCapsule> CollisionCapsules;
        /* 0x0D0 */ public List<int> DeletedConstraintsI;
        /* 0x0E0 */ public List<int> DeletedConstraintsJ;
        /* 0x0F0 */ public List<int> DeletedSimPoints;
        /* 0x100 */ public List<Vector3f> InitialShapePoints;
        /* 0x110 */ public GcConstraintsToCreateSpec ConstraintsToCreate;
        /* 0x144 */ public float AbsoluteDamping;
        /* 0x148 */ public float AirSpeedFromMovementSpeedScale;
        /* 0x14C */ public float AirSpeedOverallEffect;
        /* 0x150 */ public float ApplyGameWind;
        /* 0x154 */ public float AttachedNodesOverallBlendStrength;
        /* 0x158 */ public float ClothHeight;
        /* 0x15C */ public float DampingWrtFixed;
        // size: 0x3
        public enum InitialShapeSourceEnum : uint {
            Rectangular,
            TakenFromRenderMesh,
            Saved,
        }
        /* 0x160 */ public InitialShapeSourceEnum InitialShapeSource;
        /* 0x164 */ public int NumPointsInRenderMeshI;
        /* 0x168 */ public int NumPointsInRenderMeshJ;
        /* 0x16C */ public int NumSimPointsI;
        /* 0x170 */ public int NumSimPointsJ;
        /* 0x174 */ public float ParticleRadius;
        // size: 0x3
        public enum ScaleInTransformApplicationOnAttachmentEnum : uint {
            Multiply,
            Divide,
            Ignore,
        }
        /* 0x178 */ public ScaleInTransformApplicationOnAttachmentEnum ScaleInTransformApplicationOnAttachment;
        // size: 0x3
        public enum ScaleInTransformApplicationOnClothEnum : uint {
            Multiply,
            Divide,
            Ignore,
        }
        /* 0x17C */ public ScaleInTransformApplicationOnClothEnum ScaleInTransformApplicationOnCloth;
        // size: 0x3
        public enum ScaleInTransformApplicationOnCollisionEnum : uint {
            Multiply,
            Divide,
            Ignore,
        }
        /* 0x180 */ public ScaleInTransformApplicationOnCollisionEnum ScaleInTransformApplicationOnCollision;
        /* 0x184 */ public float StandardGravityScale;
        /* 0x188 */ public float StaticFriction;
        /* 0x18C */ public int VertexRemappingPermutation;
        /* 0x190 */ public NMSString0x40 DebugName;
        /* 0x1D0 */ public NMSString0x40 InitialShapeReferenceBone;
        /* 0x210 */ public NMSString0x40 RenderMeshNodeName;
        /* 0x250 */ public bool AttachedNodesEnabled;
        /* 0x251 */ public bool Enabled;
        /* 0x252 */ public bool VertexBasedClothRenderingEnabled;
    }
}
