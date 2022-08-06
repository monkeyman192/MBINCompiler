using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x83DF9924AAB4C52A, NameHash = 0xEEACA2899046E3A1)]
    public class GcCapeLikeInitialShape : NMSTemplate
    {
        /* 0x00 */ public float TopRadius;
        /* 0x04 */ public float TopInnerRadius;
        /* 0x08 */ public float BottomRadius;
        /* 0x0C */ public float TopDropOffHeight;
        /* 0x10 */ public float ForwardSquash;
        /* 0x20 */ public Vector3f Top;
        /* 0x30 */ public AxisSpecification RightAxis;
        /* 0x50 */ public AxisSpecification ForwardAxis;
        /* 0x70 */ public float CircleStartAngle;
        /* 0x74 */ public float CircleEndAngle;
        /* 0x78 */ public bool WrapIAround;
        /* 0x79 */ public bool WrapJAround;
        /* 0x7C */ public int NumFixedTopRowsInInitialShape;
        /* 0x80 */ public int NumExtraFixedBoundaryRowsInInitialShape;
    }
}
