using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2C9FD1F1AC98A01D, NameHash = 0x817BA03D)]
    public class GcSpringLink : NMSTemplate
    {
        [NMS(Index = 38)]
        /* 0x000 */ public Vector3f AngularLimitMaxDeg;
        [NMS(Index = 37)]
        /* 0x010 */ public Vector3f AngularLimitMinDeg;
        [NMS(Index = 39)]
        /* 0x020 */ public Vector3f AngularMotionLimitBounciness;
        [NMS(Index = 35)]
        /* 0x030 */ public Vector3f AngularMotionScale;
        [NMS(Index = 3)]
        /* 0x040 */ public Vector3f CentreOfMassLocal;
        [NMS(Index = 25)]
        /* 0x050 */ public Vector3f MotionLimitBounciness;
        [NMS(Index = 24)]
        /* 0x060 */ public Vector3f MotionLimitMax;
        [NMS(Index = 23)]
        /* 0x070 */ public Vector3f MotionLimitMin;
        [NMS(Index = 20)]
        /* 0x080 */ public Vector3f MotionScale;
        [NMS(Index = 6)]
        /* 0x090 */ public Vector3f PivotAnchorLocal;
        [NMS(Index = 4)]
        /* 0x0A0 */ public Vector3f PivotLocal;
        [NMS(Index = 2)]
        /* 0x0B0 */ public List<NMSString0x40> NodeNames;
        [NMS(Index = 10)]
        /* 0x0C0 */ public float AirSpeedFromMovementSpeedScale;
        [NMS(Index = 30)]
        /* 0x0C4 */ public float AngularDampingCriticality;
        [NMS(Index = 34)]
        /* 0x0C8 */ public float AngularMotionScale_Uniform;
        [NMS(Index = 31)]
        /* 0x0CC */ public float AngularNaturalFrequency;
        // size: 0x4
        public enum ApplyAngularLimitsInEnum : uint {
            Disabled,
            Itself,
            Parent,
            Component,
        }
        [NMS(Index = 36)]
        /* 0x0D0 */ public ApplyAngularLimitsInEnum ApplyAngularLimitsIn;
        // size: 0x5
        public enum ApplyAngularMotionScaleInEnum : uint {
            Disabled,
            Uniform,
            Itself,
            Parent,
            Component,
        }
        [NMS(Index = 33)]
        /* 0x0D4 */ public ApplyAngularMotionScaleInEnum ApplyAngularMotionScaleIn;
        [NMS(Index = 32)]
        /* 0x0D8 */ public float ApplyAngularSpringInMovingFrame;
        [NMS(Index = 8)]
        /* 0x0DC */ public float ApplyGameGravity;
        [NMS(Index = 9)]
        /* 0x0E0 */ public float ApplyGameWind;
        [NMS(Index = 28)]
        /* 0x0E4 */ public float ApplyInfluenceOfTranslationInMovingFrame;
        // size: 0x5
        public enum ApplyMotionLimitsInEnum : uint {
            Disabled,
            Uniform,
            Itself,
            Parent,
            Component,
        }
        [NMS(Index = 21)]
        /* 0x0E8 */ public ApplyMotionLimitsInEnum ApplyMotionLimitsIn;
        // size: 0x5
        public enum ApplyMotionScaleInEnum : uint {
            Disabled,
            Uniform,
            Itself,
            Parent,
            Component,
        }
        [NMS(Index = 18)]
        /* 0x0EC */ public ApplyMotionScaleInEnum ApplyMotionScaleIn;
        [NMS(Index = 14)]
        /* 0x0F0 */ public float DampingCriticality;
        [NMS(Index = 29)]
        /* 0x0F4 */ public float DistanceWhereRotationMatchesLinear;
        [NMS(Index = 27)]
        /* 0x0F8 */ public float InfluenceOfTranslation;
        [NMS(Index = 22)]
        /* 0x0FC */ public float MotionLimit_MaxDetachmentDistance;
        [NMS(Index = 19)]
        /* 0x100 */ public float MotionScale_Uniform;
        [NMS(Index = 15)]
        /* 0x104 */ public float NaturalFrequency;
        // size: 0x4
        public enum PivotAnchorsToEnum : uint {
            Itself,
            Parent,
            Node,
            NodeWithAnchor,
        }
        [NMS(Index = 5)]
        /* 0x108 */ public PivotAnchorsToEnum PivotAnchorsTo;
        [NMS(Index = 12)]
        /* 0x10C */ public float SpringHangsDown;
        [NMS(Index = 1)]
        /* 0x110 */ public NMSString0x40 Name;
        [NMS(Index = 7)]
        /* 0x150 */ public NMSString0x40 PivotAnchorNode;
        [NMS(Index = 26)]
        /* 0x190 */ public bool AngularSpringEnabled;
        [NMS(Index = 17)]
        /* 0x191 */ public bool ApplySpringInMovingFrame;
        [NMS(Index = 0)]
        /* 0x192 */ public bool Enabled;
        [NMS(Index = 13)]
        /* 0x193 */ public bool PositionalSpringEnabled;
        [NMS(Index = 11)]
        /* 0x194 */ public bool SpringCollides;
        [NMS(Index = 16)]
        /* 0x195 */ public bool SpringPivots;
    }
}
