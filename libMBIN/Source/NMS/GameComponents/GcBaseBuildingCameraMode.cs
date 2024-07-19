namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5D13D519EB4A2176, NameHash = 0xCE31A5B9)]
    public class GcBaseBuildingCameraMode : NMSTemplate
    {
        // size: 0x3
        public enum BaseBuildingCameraModeEnum : uint {
            Inactive,
            FreeCam,
            FocusCam,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BaseBuildingCameraModeEnum BaseBuildingCameraMode;
    }
}
