namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAC465F34E037CDE4, NameHash = 0xFB02F29777CB9D8B)]
    public class GcCameraAnomalySetupData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Vector4f CameraAt;
        [NMS(Index = 2)]
        /* 0x10 */ public Vector4f CameraOffset;
        [NMS(Index = 1)]
        /* 0x20 */ public Vector4f CameraUp;
        [NMS(Index = 3)]
        /* 0x30 */ public Vector4f SunDirection;
    }
}
