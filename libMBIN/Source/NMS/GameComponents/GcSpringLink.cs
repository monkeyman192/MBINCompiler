using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE40748D916B2F0B9, NameHash = 0x4B56CD3D914485CF)]
    public class GcSpringLink : NMSTemplate
    {
        /* 0x000 */ public bool Enabled;
        /* 0x001 */ public NMSString0x40 DebugName;
        /* 0x048 */ public List<NMSString0x40> NodeNames;
        /* 0x060 */ public Vector3f SpringCentreLocal;
        /* 0x070 */ public Vector3f SpringPivotLocal;
        /* 0x080 */ public bool PositionalSpringEnabled;
        /* 0x084 */ public float DampingCriticality;
        /* 0x088 */ public float NaturalFrequency;
        /* 0x08C */ public bool SpringPivotsAsOpposedToParallelTransport;
        /* 0x08D */ public bool ApplySpringInMovingFrame;
        public enum ApplyMotionScaleInEnum { Disabled, Uniform, Itself, Parent, Component }
        /* 0x090 */ public ApplyMotionScaleInEnum ApplyMotionScaleIn;
        /* 0x094 */ public float MotionScale_Uniform;
        /* 0x0A0 */ public Vector3f MotionScale;
        public enum ApplyMotionLimitsInEnum { Disabled, Itself, Parent, Component }
        /* 0x0B0 */ public ApplyMotionLimitsInEnum ApplyMotionLimitsIn;
        /* 0x0C0 */ public Vector3f MotionLimitMin;
        /* 0x0D0 */ public Vector3f MotionLimitMax;
        /* 0x0E0 */ public Vector3f MotionLimitBounciness;
        /* 0x0F0 */ public bool AngularSpringEnabled;
        /* 0x0F4 */ public float AngularDampingCriticality;
        /* 0x0F8 */ public float AngularNaturalFrequency;
        /* 0x0FC */ public bool ApplyAngularSpringInMovingFrame;
        public enum ApplyAngularMotionScaleInEnum { Disabled, Uniform, Itself, Parent, Component }
        /* 0x100 */ public ApplyAngularMotionScaleInEnum ApplyAngularMotionScaleIn;
        /* 0x104 */ public float AngularMotionScale_Uniform;
        /* 0x110 */ public Vector3f AngularMotionScale;
        public enum ApplyAngularLimitsInEnum { Disabled, Itself, Parent, Component }
        /* 0x120 */ public ApplyAngularLimitsInEnum ApplyAngularLimitsIn;
        /* 0x130 */ public Vector3f AngularLimitMinDeg;
        /* 0x140 */ public Vector3f AngularLimitMaxDeg;
        /* 0x150 */ public Vector3f AngularMotionLimitBounciness;
        /* 0x160 */ public List<NMSString0x40> NodesThatMustBePresent;
    }
}
