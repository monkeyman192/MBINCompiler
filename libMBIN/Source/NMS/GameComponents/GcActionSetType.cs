namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD9A33E76B850BB6D, NameHash = 0x7BFD50A3)]
    public class GcActionSetType : NMSTemplate
    {
        // size: 0x28
        public enum ActionSetTypeEnum : uint {
            None,
            FRONTEND,
            Frontend_Right,
            Frontend_Left,
            OnFootControls,
            OnFootControls_Right,
            OnFootControls_Left,
            OnFootQuickMenu,
            OnFootQuickMenu_Right,
            OnFootQuickMenu_Left,
            ShipControls,
            ShipControls_Right,
            ShipControls_Left,
            ShipQuickMenu,
            ShipQuickMenu_Right,
            ShipQuickMenu_Left,
            VehicleMode,
            VehicleMode_Right,
            VehicleMode_Left,
            VehicleQuickMenu,
            VehicleQuickMenu_Right,
            VehicleQuickMenu_Left,
            GalacticMap,
            GalacticMap_Right,
            GalacticMap_Left,
            PhotoModeMenu,
            PhotoModeMenu_Right,
            PhotoModeMenu_Left,
            PhotoModeMvCam,
            PhotoModeMvCam_Right,
            PhotoModeMvCam_Left,
            AmbientMode,
            DebugMode,
            TextChat,
            BuildMenuSelectionMode,
            BuildMenuSelectionMode_Right,
            BuildMenuSelectionMode_Left,
            BuildMenuPlacementMode,
            BuildMenuPlacementMode_Right,
            BuildMenuPlacementMode_Left,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ActionSetTypeEnum ActionSetType;
    }
}
