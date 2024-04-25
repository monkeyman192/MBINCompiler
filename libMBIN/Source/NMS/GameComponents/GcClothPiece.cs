using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x615EA6466922EFC5, NameHash = 0x7596FBA2C232AC37)]
    public class GcClothPiece : NMSTemplate
    {
        [NMS(Index = 22)]
        /* 0x000 */ public GcRectangularInitialShape RectangularInitialShape;
        [NMS(Index = 33)]
        /* 0x040 */ public GcAdvancedTweaks Advanced;
        [NMS(Index = 31)]
        /* 0x080 */ public List<GcAttachedNode> AttachedNodes;
        [NMS(Index = 25)]
        /* 0x090 */ public List<GcClothAttachmentCirlce> AttachmentCircles;
        [NMS(Index = 26)]
        /* 0x0A0 */ public List<GcClothAttachmentLine> AttachmentLines;
        [NMS(Index = 27)]
        /* 0x0B0 */ public List<GcAttachmentPointSet> AttachmentPointSets;
        [NMS(Index = 24)]
        /* 0x0C0 */ public List<GcCollisionCapsule> CollisionCapsules;
        [NMS(Index = 35)]
        /* 0x0D0 */ public List<int> DeletedConstraintsI;
        [NMS(Index = 36)]
        /* 0x0E0 */ public List<int> DeletedConstraintsJ;
        [NMS(Index = 34)]
        /* 0x0F0 */ public List<int> DeletedSimPoints;
        [NMS(Index = 23)]
        /* 0x100 */ public List<Vector3f> InitialShapePoints;
        [NMS(Index = 28)]
        /* 0x110 */ public GcConstraintsToCreateSpec ConstraintsToCreate;
        [NMS(Index = 12)]
        /* 0x144 */ public float AbsoluteDamping;
        [NMS(Index = 14)]
        /* 0x148 */ public float AirSpeedFromMovementSpeedScale;
        [NMS(Index = 15)]
        /* 0x14C */ public float AirSpeedOverallEffect;
        [NMS(Index = 13)]
        /* 0x150 */ public float ApplyGameWind;
        [NMS(Index = 32)]
        /* 0x154 */ public float AttachedNodesOverallBlendStrength;
        [NMS(Index = 8)]
        /* 0x158 */ public float ClothHeight;
        [NMS(Index = 11)]
        /* 0x15C */ public float DampingWrtFixed;
        // size: 0x3
        public enum InitialShapeSourceEnum : uint {
            Rectangular,
            TakenFromRenderMesh,
            Saved,
        }
        [NMS(Index = 21)]
        /* 0x160 */ public InitialShapeSourceEnum InitialShapeSource;
        [NMS(Index = 3)]
        /* 0x164 */ public int NumPointsInRenderMeshI;
        [NMS(Index = 4)]
        /* 0x168 */ public int NumPointsInRenderMeshJ;
        [NMS(Index = 6)]
        /* 0x16C */ public int NumSimPointsI;
        [NMS(Index = 7)]
        /* 0x170 */ public int NumSimPointsJ;
        [NMS(Index = 9)]
        /* 0x174 */ public float ParticleRadius;
        // size: 0x3
        public enum ScaleInTransformApplicationOnAttachmentEnum : uint {
            Multiply,
            Divide,
            Ignore,
        }
        [NMS(Index = 20)]
        /* 0x178 */ public ScaleInTransformApplicationOnAttachmentEnum ScaleInTransformApplicationOnAttachment;
        // size: 0x3
        public enum ScaleInTransformApplicationOnClothEnum : uint {
            Multiply,
            Divide,
            Ignore,
        }
        [NMS(Index = 18)]
        /* 0x17C */ public ScaleInTransformApplicationOnClothEnum ScaleInTransformApplicationOnCloth;
        // size: 0x3
        public enum ScaleInTransformApplicationOnCollisionEnum : uint {
            Multiply,
            Divide,
            Ignore,
        }
        [NMS(Index = 19)]
        /* 0x180 */ public ScaleInTransformApplicationOnCollisionEnum ScaleInTransformApplicationOnCollision;
        [NMS(Index = 16)]
        /* 0x184 */ public float StandardGravityScale;
        [NMS(Index = 10)]
        /* 0x188 */ public float StaticFriction;
        [NMS(Index = 5)]
        /* 0x18C */ public int VertexRemappingPermutation;
        [NMS(Index = 1)]
        /* 0x190 */ public NMSString0x40 DebugName;
        [NMS(Index = 17)]
        /* 0x1D0 */ public NMSString0x40 InitialShapeReferenceBone;
        [NMS(Index = 2)]
        /* 0x210 */ public NMSString0x40 RenderMeshNodeName;
        [NMS(Index = 30)]
        /* 0x250 */ public bool AttachedNodesEnabled;
        [NMS(Index = 0)]
        /* 0x251 */ public bool Enabled;
        [NMS(Index = 29)]
        /* 0x252 */ public bool VertexBasedClothRenderingEnabled;
    }
}
