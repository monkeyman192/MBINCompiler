using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6850850E649408B4, NameHash = 0x582DEC8E)]
    public class GcClothPiece : NMSTemplate
    {
        [NMS(Index = 31)]
        /* 0x000 */ public GcAdvancedTweaks Advanced;
        [NMS(Index = 29)]
        /* 0x040 */ public List<GcAttachedNode> AttachedNodes;
        [NMS(Index = 26)]
        /* 0x050 */ public List<GcAttachmentPointSet> AttachmentPointSets;
        [NMS(Index = 25)]
        /* 0x060 */ public List<GcCollisionCapsule> CollisionCapsules;
        [NMS(Index = 33)]
        /* 0x070 */ public List<int> DeletedConstraintsI;
        [NMS(Index = 34)]
        /* 0x080 */ public List<int> DeletedConstraintsJ;
        [NMS(Index = 32)]
        /* 0x090 */ public List<int> DeletedSimPoints;
        [NMS(Index = 23)]
        /* 0x0A0 */ public List<SimShape> InitialShapes;
        [NMS(Index = 24)]
        /* 0x0B0 */ public List<Mapping> Mappings;
        [NMS(Index = 3)]
        /* 0x0C0 */ public DirectMesh DirectMesh;
        [NMS(Index = 27)]
        /* 0x118 */ public GcConstraintsToCreateSpec ConstraintsToCreate;
        [NMS(Index = 9)]
        /* 0x14C */ public float AbsoluteDamping;
        [NMS(Index = 13)]
        /* 0x150 */ public float AirSpeedFromMovementSpeedScale;
        [NMS(Index = 14)]
        /* 0x154 */ public float AirSpeedOverallEffect;
        [NMS(Index = 11)]
        /* 0x158 */ public float ApplyGameWind;
        [NMS(Index = 30)]
        /* 0x15C */ public float AttachedNodesOverallBlendStrength;
        [NMS(Index = 8)]
        /* 0x160 */ public float DampingWrtFixed;
        // size: 0x3
        public enum InitialShapeSourceEnum : uint {
            Rectangular,
            TakenFromDirectMesh,
            Saved,
        }
        [NMS(Index = 20)]
        /* 0x164 */ public InitialShapeSourceEnum InitialShapeSource;
        [NMS(Index = 15)]
        /* 0x168 */ public int NumConstraintSolvingIterations;
        [NMS(Index = 16)]
        /* 0x16C */ public int NumTimestepsSubdivisions;
        [NMS(Index = 10)]
        /* 0x170 */ public float ParticleRadius;
        // size: 0x3
        public enum ScaleInTransformApplicationOnAttachmentEnum : uint {
            Multiply,
            Divide,
            Ignore,
        }
        [NMS(Index = 19)]
        /* 0x174 */ public ScaleInTransformApplicationOnAttachmentEnum ScaleInTransformApplicationOnAttachment;
        // size: 0x3
        public enum ScaleInTransformApplicationOnClothEnum : uint {
            Multiply,
            Divide,
            Ignore,
        }
        [NMS(Index = 17)]
        /* 0x178 */ public ScaleInTransformApplicationOnClothEnum ScaleInTransformApplicationOnCloth;
        // size: 0x3
        public enum ScaleInTransformApplicationOnCollisionEnum : uint {
            Multiply,
            Divide,
            Ignore,
        }
        [NMS(Index = 18)]
        /* 0x17C */ public ScaleInTransformApplicationOnCollisionEnum ScaleInTransformApplicationOnCollision;
        [NMS(Index = 6)]
        /* 0x180 */ public float StandardGravityScale;
        [NMS(Index = 7)]
        /* 0x184 */ public float StaticFriction;
        [NMS(Index = 21)]
        /* 0x188 */ public NMSString0x40 InitialShapeName;
        [NMS(Index = 5)]
        /* 0x1C8 */ public MappedMesh MappedMesh;
        [NMS(Index = 22)]
        /* 0x208 */ public NMSString0x40 MappingName;
        [NMS(Index = 1)]
        /* 0x248 */ public NMSString0x40 Name;
        [NMS(Index = 28)]
        /* 0x288 */ public bool AttachedNodesEnabled;
        [NMS(Index = 2)]
        /* 0x289 */ public bool DriveDirectMesh;
        [NMS(Index = 4)]
        /* 0x28A */ public bool DriveMappedMesh;
        [NMS(Index = 0)]
        /* 0x28B */ public bool Enabled;
        [NMS(Index = 12)]
        /* 0x28C */ public bool MoreWindAtBottom;
    }
}
