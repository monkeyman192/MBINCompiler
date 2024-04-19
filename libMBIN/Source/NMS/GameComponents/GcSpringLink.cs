using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6E4CEEBDD7911A13, NameHash = 0x4B56CD3D914485CF)]
    public class GcSpringLink : NMSTemplate
    {
        /* 0x000 */ public Vector3f AngularLimitMaxDeg;
        /* 0x010 */ public Vector3f AngularLimitMinDeg;
        /* 0x020 */ public Vector3f AngularMotionLimitBounciness;
        /* 0x030 */ public Vector3f AngularMotionScale;
        /* 0x040 */ public Vector3f CentreOfMassLocal;
        /* 0x050 */ public Vector3f MotionLimitBounciness;
        /* 0x060 */ public Vector3f MotionLimitMax;
        /* 0x070 */ public Vector3f MotionLimitMin;
        /* 0x080 */ public Vector3f MotionScale;
        /* 0x090 */ public Vector3f PivotAnchorLocal;
        /* 0x0A0 */ public Vector3f PivotLocal;
        /* 0x0B0 */ public List<NMSString0x40> NodeNames;
        /* 0x0C0 */ public float AirSpeedFromMovementSpeedScale;
        /* 0x0C4 */ public float AngularDampingCriticality;
        /* 0x0C8 */ public float AngularMotionScale_Uniform;
        /* 0x0CC */ public float AngularNaturalFrequency;
        // size: 0x4
        public enum ApplyAngularLimitsInEnum : uint {
            Disabled,
            Itself,
            Parent,
            Component,
        }
        /* 0x0D0 */ public ApplyAngularLimitsInEnum ApplyAngularLimitsIn;
        // size: 0x5
        public enum ApplyAngularMotionScaleInEnum : uint {
            Disabled,
            Uniform,
            Itself,
            Parent,
            Component,
        }
        /* 0x0D4 */ public ApplyAngularMotionScaleInEnum ApplyAngularMotionScaleIn;
        /* 0x0D8 */ public float ApplyAngularSpringInMovingFrame;
        /* 0x0DC */ public float ApplyGameGravity;
        /* 0x0E0 */ public float ApplyGameWind;
        /* 0x0E4 */ public float ApplyInfluenceOfTranslationInMovingFrame;
        // size: 0x5
        public enum ApplyMotionLimitsInEnum : uint {
            Disabled,
            Uniform,
            Itself,
            Parent,
            Component,
        }
        /* 0x0E8 */ public ApplyMotionLimitsInEnum ApplyMotionLimitsIn;
        // size: 0x5
        public enum ApplyMotionScaleInEnum : uint {
            Disabled,
            Uniform,
            Itself,
            Parent,
            Component,
        }
        /* 0x0EC */ public ApplyMotionScaleInEnum ApplyMotionScaleIn;
        /* 0x0F0 */ public float DampingCriticality;
        /* 0x0F4 */ public float DistanceWhereRotationMatchesLinear;
        /* 0x0F8 */ public float InfluenceOfTranslation;
        /* 0x0FC */ public float MotionLimit_MaxDetachmentDistance;
        /* 0x100 */ public float MotionScale_Uniform;
        /* 0x104 */ public float NaturalFrequency;
        // size: 0x4
        public enum PivotAnchorsToEnum : uint {
            Itself,
            Parent,
            Node,
            NodeWithAnchor,
        }
        /* 0x108 */ public PivotAnchorsToEnum PivotAnchorsTo;
        /* 0x10C */ public float SpringHangsDown;
        /* 0x110 */ public NMSString0x40 Name;
        /* 0x150 */ public NMSString0x40 PivotAnchorNode;
        /* 0x190 */ public bool AngularSpringEnabled;
        /* 0x191 */ public bool ApplySpringInMovingFrame;
        /* 0x192 */ public bool Enabled;
        /* 0x193 */ public bool PositionalSpringEnabled;
        /* 0x194 */ public bool SpringCollides;
        /* 0x195 */ public bool SpringPivots;
    }
}
