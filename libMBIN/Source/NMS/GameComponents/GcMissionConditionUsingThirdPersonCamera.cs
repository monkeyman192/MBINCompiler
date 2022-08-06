using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5993895CC7D60EEA, NameHash = 0x1966AFFB10CA6C7C)]
    public class GcMissionConditionUsingThirdPersonCamera : NMSTemplate
    {
        public enum UsingCameraModeEnum { OnFoot, Ship, Vehicle }
        public UsingCameraModeEnum UsingCameraMode;
    }
}
