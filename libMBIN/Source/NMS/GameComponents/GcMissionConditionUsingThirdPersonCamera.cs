namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB9D1A5B382D201F1, NameHash = 0xE83447E4)]
    public class GcMissionConditionUsingThirdPersonCamera : NMSTemplate
    {
        // size: 0x3
        public enum UsingCameraModeEnum : uint {
            OnFoot,
            Ship,
            Vehicle,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public UsingCameraModeEnum UsingCameraMode;
    }
}
