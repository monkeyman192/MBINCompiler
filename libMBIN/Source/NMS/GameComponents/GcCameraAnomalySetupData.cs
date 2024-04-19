namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAC465F34E037CDE4, NameHash = 0xFB02F29777CB9D8B)]
    public class GcCameraAnomalySetupData : NMSTemplate
    {
        /* 0x00 */ public Vector4f CameraAt;
        /* 0x10 */ public Vector4f CameraOffset;
        /* 0x20 */ public Vector4f CameraUp;
        /* 0x30 */ public Vector4f SunDirection;
    }
}
