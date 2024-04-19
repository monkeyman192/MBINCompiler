namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x76B2659569080EDE, NameHash = 0xCF22467E41623053)]
    public class GcDebugCameraEntry : NMSTemplate
    {
        /* 0x00 */ public Vector3f Facing;
        /* 0x10 */ public Vector3f Local;
        /* 0x20 */ public Vector3f Offset;
        /* 0x30 */ public Vector3f Up;
        /* 0x40 */ public float Distance;
        /* 0x44 */ public float FOV;
        /* 0x48 */ public float SpeedModifier;
    }
}
