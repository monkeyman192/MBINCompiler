using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xFC00A68A4FADC0C3, NameHash = 0x99FB64404DAF2DE7)]
    public class GcActionSetType : NMSTemplate
    {
        // size: 0x10
        public enum ActionSetTypeEnum {
            None, FRONTEND, OnFootControls, OnFootQuickMenu, ShipControls, ShipQuickMenu, VehicleMode, GalacticMap, PhotoModeMenu, PhotoModeMvCam,
            AmbientMode, DebugMode, BuildMenuAnalogueRotate, TextChat, BuildMenuSelectionMode, BuildMenuPlacementMode
        }
        public ActionSetTypeEnum ActionSetType;
    }
}