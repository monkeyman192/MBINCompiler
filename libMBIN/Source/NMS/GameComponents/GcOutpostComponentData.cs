using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcOutpostComponentData : NMSTemplate
    {
        /* 0x000 */ public bool SpaceStation;
        /* 0x001 */ public bool AIDestination;
        /* 0x002 */ public bool HasOwnGravity;

        /* 0x004 */ public float ApproachCircleRadius;
        /* 0x008 */ public float ApproachRange;
        /* 0x00C */ public float ApproachAngle;
        /* 0x010 */ public float ApproachSpeed;

        /* 0x014 */ public float LandingSpeed;
        /* 0x018 */ public float LandingHeight;
        /* 0x01C */ public bool RotateToDock;

        /* 0x020 */ public float TakeOffHeight;
        /* 0x024 */ public float TakeOffFwdDist;
        /* 0x028 */ public float TakeOffTime;
        /* 0x02C */ public float TakeOffAlignTime;
        /* 0x030 */ public float TakeOffSpeed;
        /* 0x034 */ public float TakeOffBoost;

        /* 0x038 */ public List<GcOutpostLSystemPair> LSystems;
    }
}
