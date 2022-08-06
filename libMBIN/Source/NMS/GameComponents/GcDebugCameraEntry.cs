using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7417707B793B2ED1, NameHash = 0xCF22467E41623053)]
    public class GcDebugCameraEntry : NMSTemplate
    {
        /* 0x00 */ public Vector3f Offset;
        /* 0x10 */ public Vector3f Local;
        /* 0x20 */ public Vector3f Facing;
        /* 0x30 */ public Vector3f Up;
        /* 0x40 */ public float FOV;
        /* 0x44 */ public float SpeedModifier;
        /* 0x48 */ public float Distance;
    }
}
