using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x9FF8C33BBF3A4F8F, NameHash = 0x99FB64404DAF2DE7)]
    public class GcActionSetType : NMSTemplate
    {
        // 0xE entries
        public enum ActionSetTypeEnum { None, FRONTEND, OnFootControls, OnFootQuickMenu, ShipControls, ShipQuickMenu, VehicleMode, GalacticMap, PhotoModeMenu,
            PhotoModeMvCam, AmbientMode, DebugMode, BuildMenuAnalogueRotate, TextChat }
        public ActionSetTypeEnum ActionSetType;
    }
}
